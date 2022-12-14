using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2
{
    public class AccountManage
    {
        //mongoURL
        private static readonly MongoClientSettings Settings = MongoClientSettings.FromConnectionString(
            "mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");

        private static readonly MongoClient Client = new MongoClient(Settings);
        private static readonly IMongoDatabase Database = Client.GetDatabase("LibrarySystem");

        private static readonly IMongoCollection<Account> Collection = Database.GetCollection<Account>("Accounts");
        //reaching into the account table

        private List<Account> _accountsList = new List<Account>();

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

        public static void RemoveAccount(ObjectId id)
        {
            Collection.DeleteOne(a => a.Id == id);
        }

        public static void UpdateAccount(string id, string password, string name)
        {
            var updateDefinition = Builders<Account>.Update
                .Set(a => a.Password, password)
                .Set(a => a.Name, name);
            Collection.UpdateOne(a => a.Id.Equals(id), updateDefinition);
        }
    }
}