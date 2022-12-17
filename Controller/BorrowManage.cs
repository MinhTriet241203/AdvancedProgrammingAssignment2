using AdvancedProgrammingAssignment2.Model;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2.Controller
{
    public class BorrowManage
    {
        //URL for connecting to MongoDB
        private static readonly MongoClientSettings Settings = MongoClientSettings.FromConnectionString(
            "mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");

        private static readonly MongoClient Client = new MongoClient(Settings);
        private static readonly IMongoDatabase Database = Client.GetDatabase("LibrarySystem");

        //reaching into the category, book table, these are the collections that is retrieved from the database
        private static readonly IMongoCollection<Category> CategoryCollection =
            Database.GetCollection<Category>("Categories");

        private static readonly IMongoCollection<Book> BookCollection =
            Database.GetCollection<Book>("Books");

        private static readonly IMongoCollection<Borrowing> BorrowCollection =
            Database.GetCollection<Borrowing>("Borrow");
    }
}