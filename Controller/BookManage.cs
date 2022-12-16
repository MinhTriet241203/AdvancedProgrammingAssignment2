using System;
using System.Collections.Generic;
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
            //return the book list
            var books = BookCollection.AsQueryable().ToList();
            return books;
            //then over on the view side we can check the length of the books list 
        }

        public static List<Book> SearchBook(string keyword)
        {
            //return the list of books that matches the search keyword
            var searchedBooks = BookCollection.Find(a => a.BookName.Contains(keyword)).ToList();
            return searchedBooks;
        }

        //receives information about the book, minus the Id and the BorrowStatus
        public static string AddBook(string isbn, string bookName, string category, string author, string image)
        {
            var filter = Builders<Category>.Filter.Eq("CategoryName", category);
            if (CategoryCollection.Find(filter).CountDocuments() != 0)
            {
                Book newBook = new Book(isbn, bookName, category, author, image);
                BookCollection.InsertOne(newBook);
                return $"New book: \"{bookName}\" by \"{author}\" added successfully!";
            }

            return $"Book \"{bookName}\" already exists, please try again.";
        }

        //remove the book using id
        public static string RemoveBook(string id)
        {
            try
            {
                if ((int)BookCollection.Find(b => b.Id == ObjectId.Parse(id) && b.BorrowState != "Borrowing")
                        .CountDocuments() == 0)
                    return "Book currently in use, please try again at another time.";
                {
                    BookCollection.DeleteOne(b => b.Id == ObjectId.Parse(id));
                    return "Book deleted successfully!";
                }
            }
            catch (Exception)
            {
                return "Something went wrong, please try again.";
            }
        }

        //update book receiving id and information, minus BorrowState
        public static string UpdateBook(string id, string isbn, string bookName, string category, string author,
            string image)
        {
            try
            {
                var updateDefinition = Builders<Book>.Update
                    .Set(b => b.Isbn, isbn)
                    .Set(b => b.BookName, bookName)
                    .Set(b => b.Category, category)
                    .Set(b => b.Author, author)
                    .Set(b => b.Image, image);
                BookCollection.UpdateOne(b => b.Id == ObjectId.Parse(id), updateDefinition);
                return "Updated book successfully.";
            }
            catch (Exception)
            {
                return "Something went wrong, please try again.";
            }
        }
    }
}