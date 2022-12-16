using System;
using AdvancedProgrammingAssignment2.Model;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2.Controller
{
    public class AuthenticationController
    {
        //URL for connecting to MongoDB
        private static readonly MongoClientSettings Settings = MongoClientSettings.FromConnectionString(
            "mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");

        private static readonly MongoClient Client = new MongoClient(Settings);
        private static readonly IMongoDatabase Database = Client.GetDatabase("LibrarySystem");

        //reaching into the account table, this is the collection that is retrieved from the database
        private static readonly IMongoCollection<Account> Collection = Database.GetCollection<Account>("Accounts");

        private static string AvailableAccountsCheck(string email)
        {
            //this check for valid account email
            var filter = Builders<Account>.Filter.Eq("Email", email);
            return Collection.Find(filter) != null ? "valid" : "invalid";
        }

        //use the Login method by checking if the output is type string = "success"
        public static string Login(string inputEmail, string inputPassword)
        {
            //normalise the email and add it to filter
            var filter = Builders<Account>.Filter.Eq("Email", inputEmail.ToLower());
            if (AvailableAccountsCheck(inputEmail)
                .Equals("invalid")) return "invalid email"; //can set error and stuffs here.
            try
            {
                Account account = Collection.Find(filter).First();
                var email = account.Email.ToLower();
                var password = account.Password;
                var accountClass = account.AccountClass;

                //lookup the database password
                if (password.Equals(inputPassword)) return accountClass;
                return "Incorrect password for email!";
            }
            catch (Exception)
            {
                return "Email not found";
            }
        }

        public static string RegisterAccount(string inputEmail, string inputName, string inputPassword)
        {
            //check for email availability
            var checkResult = AvailableAccountsCheck(inputEmail);
            if (checkResult == "invalid") return "Email is already in use, please try again.";
            try
            {
                AccountManage.AddUser(inputEmail, inputName, inputPassword);
                return "Created new account successfully!";
            }
            catch (Exception)
            {
                return "Something went wrong, please try again.";
            }
        }
    }
}