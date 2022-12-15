using System;
using System.Collections.Generic;
using AdvancedProgrammingAssignment2.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2.Controller
{
    public class AccountManage
    {
        //URL for connecting to MongoDB
        private static readonly MongoClientSettings Settings = MongoClientSettings.FromConnectionString(
            "mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");

        private static readonly MongoClient Client = new MongoClient(Settings);
        private static readonly IMongoDatabase Database = Client.GetDatabase("LibrarySystem");

        //reaching into the account table, this is the collection that is retrieved from the database
        private static readonly IMongoCollection<Account> Collection = Database.GetCollection<Account>("Accounts");

        //this list is for later use in the app itself, lower response time instead of waiting for the db solely.
        private static List<Account> _accountsList = new List<Account>();

        public static List<Account> GetAllAccounts()
        {
            var list = Collection.AsQueryable().ToList();
            return list;
        }

        public static string availableAccountsCheck(string email)
        {
            //this check for valid account email
            var filter = Builders<Account>.Filter.Eq("Email", email);
            return Collection.Find(filter) != null ? "valid" : "invalid";
        }

        //The three methods below are for adding accounts, Admin, librarian, and user accounts.
        public static void AddAdmin(string email, string name, string password)
        {
            Admin adminAccount = new Admin(email.ToLower(), name, password);
            Collection.InsertOne(adminAccount);
        }

        public static void AddLibrarian(string email, string name, string password)
        {
            Librarian librarianAccount = new Librarian(email.ToLower(), name, password);
            Collection.InsertOne(librarianAccount);
        }

        public static void AddUser(string email, string name, string password)
        {
            User userAccount = new User(email.ToLower(), name, password);
            Collection.InsertOne(userAccount);
        }

        //this part delete accounts from db by matching [Id] to received [id]
        public static void RemoveAccount(ObjectId id)
        {
            Collection.DeleteOne(a => a.Id == id);
        }

        public static void RemoveAccount(string email)
        {
            Collection.DeleteOne(a => a.Email == email);
        }

        //this part updates the accounts with new information regarding the password and name.
        //it then updates the account with matching [Id] with the new information.
        public static void UpdateAccount(string id, string password, string name)
        {
            var updateDefinition = Builders<Account>.Update
                .Set(a => a.Password, password)
                .Set(a => a.Name, name);
            Collection.UpdateOne(a => a.Id == ObjectId.Parse(id), updateDefinition);
        }

        //use the Login method by checking if the output is type string = "success"
        public static string Login(string inputEmail, string inputPassword)
        {
            //normalise the email and add it to filter
            var filter = Builders<Account>.Filter.Eq("Email", inputEmail.ToLower());
            if (availableAccountsCheck(inputEmail)
                .Equals("invalid")) return "invalid email"; //can set error and stuffs here.

            try
            {
                Account account = Collection.Find(filter).First();
                var email = account.Email.ToLower();
                var password = account.Password;

                if (email.Equals(inputEmail) && password.Equals(inputPassword)) return "success";

                return "Email or password is incorrect";
            }
            catch (Exception e)
            {
                return "Email not found";
            }
        }
    }
}