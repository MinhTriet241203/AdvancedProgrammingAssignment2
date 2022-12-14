using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2
{
    public class AccountManage
    {
        static MongoClientSettings settings = MongoClientSettings.FromConnectionString(
            "mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");

        static MongoClient client = new MongoClient(settings);

        //setting up connection to db
        static IMongoDatabase database = client.GetDatabase("LibrarySystem");

        static IMongoCollection<Account> collection = database.GetCollection<Account>("Accounts");
        //reaching into the account table

        private List<Account> _accountsList = new List<Account>();

        public static void AddAdmin(string email, string password, string name)
        {
            Admin adminAccount = new Admin(email, password, name);
            collection.InsertOne(adminAccount);
        }

        public static void AddLibrarian(string email, string password, string name)
        {
            Librarian librarianAccount = new Librarian(email, password, name);
            collection.InsertOne(librarianAccount);
        }

        public static void AddUser(string email, string password, string name)
        {
            User userAccount = new User(email, password, name);
            collection.InsertOne(userAccount);
        }

        public static void RemoveAccount(ObjectId id)
        {
            //todo: remove from list and db.
        }

        public static void UpdateAccount(string id)
        {
            //todo: add method that updates account, class not included.
        }
    }
}