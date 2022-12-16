using System;
using System.Collections.Generic;
using System.Windows.Markup;
using AdvancedProgrammingAssignment2.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2.Controller
{
    public class BookManage
    {
        //URL for connecting to MongoDB
        private static readonly MongoClientSettings Settings = MongoClientSettings.FromConnectionString(
            "mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");

        private static readonly MongoClient Client = new MongoClient(Settings);
        private static readonly IMongoDatabase Database = Client.GetDatabase("LibrarySystem");

        //reaching into the category and book table, these are the collections that is retrieved from the database
        private static readonly IMongoCollection<Category> CategoryCollection =
            Database.GetCollection<Category>("Categories");

        private static readonly IMongoCollection<Book> BookCollection = Database.GetCollection<Book>("Books");
        
        public static List<Book> GetBooks()
        {
            var books = BookCollection.AsQueryable().ToList();
            return books;
            //then over on the view side we can check the length of the books list 
        }

        public static bool AddBook(string isbn, string bookName, string category, string author, string image)
        {
            var filter = Builders<Category>.Filter.Eq("CategoryName", category);
            if (CategoryCollection.Find(filter).CountDocuments() != 0)
            {
                Book newBook = new Book(isbn, bookName, category, author, image);
                return true;
            }

            return false;
        }

        public static bool RemoveBook(ObjectId id)
        {
            try
            {
                BookCollection.DeleteOne(a => a.Id == id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}