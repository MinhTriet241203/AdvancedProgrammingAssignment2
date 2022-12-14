using System;
using System.Collections.Generic;
using AdvancedProgrammingAssignment2.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

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

        public static List<Account> GetAllLibrarians()
        {
            var list = Collection.AsQueryable().Where(a => a.AccountClass == "Librarians").ToList();
            return list;
        }

        public static List<Account> GetAllUsers()
        {
            var list = Collection.AsQueryable().Where(a => a.AccountClass == "Users").ToList();
            return list;
        }

        public List<Account> SearchAccount(string searchKeyword)
        {
            var accountList = Collection.Find(a => a.Email.Contains(searchKeyword) || a.Name.Contains(searchKeyword))
                .ToList();
            return accountList;
        }

        //The three methods below are for adding accounts, Admin, librarian, and user accounts.
        public static void AddAdmin(string email, string name, string password)
        {
            var adminAccount = new Admin(email.ToLower(), name, password);
            Collection.InsertOne(adminAccount);
        }

        public static void AddLibrarian(string email, string name, string password)
        {
            var librarianAccount = new Librarian(email.ToLower(), name, password);
            Collection.InsertOne(librarianAccount);
        }

        public static string AddUser(string email, string name, string password)
        {
            try
            {
                var userAccount = new User(email.ToLower(), name, password);
                Collection.InsertOne(userAccount);
                return "Account created successfully!";
            }
            catch (Exception)
            {
                return "Could not create account! Please check the list again.";
            }
        }

        //this part delete accounts from db by matching [Id] to received [id]
        public static string RemoveAccount(ObjectId id)
        {
            try
            {
                Collection.DeleteOne(a => a.Id == id);
                return "Account deleted successfully!";
            }
            catch (Exception)
            {
                return "Account deletion failed, please check if the account exists.";
            }
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
    }
}