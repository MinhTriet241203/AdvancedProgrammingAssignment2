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
        private List<Account> _accountsList = new List<Account>();

        //The three methods below are for adding accounts, Admin, librarian, and user accounts.
        public static void AddAdmin(string email, string password, string name)
        {
            Admin adminAccount = new Admin(email, name, password);
            Collection.InsertOne(adminAccount);
        }

        public static void AddLibrarian(string email, string password, string name)
        {
            Librarian librarianAccount = new Librarian(email, name, password);
            Collection.InsertOne(librarianAccount);
        }

        public static void AddUser(string email, string password, string name)
        {
            User userAccount = new User(email, name, password);
            Collection.InsertOne(userAccount);
        }

        //this part delete accounts from db by matching [Id] to received [id]
        public static void RemoveAccount(ObjectId id)
        {
            Collection.DeleteOne(a => a.Id == id);
        }

        //this part updates the accounts with new information regarding the password and name.
        //it then updates the account with matching [Id] with the new information.
        public static void UpdateAccount(ObjectId id, string password, string name)
        {
            var updateDefinition = Builders<Account>.Update
                .Set(a => a.Password, password)
                .Set(a => a.Name, name);
            Collection.UpdateOne(a => a.Id.Equals(id), updateDefinition);
        }
    }
}