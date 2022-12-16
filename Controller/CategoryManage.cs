using System;
using System.Collections.Generic;
using AdvancedProgrammingAssignment2.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2.Controller
{
    public class CategoryManage
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

        private static List<Category> _categoryList = new List<Category>();

        public static List<Category> ShowCategory()
        {
            _categoryList = CategoryCollection.Find(new BsonDocument()).ToList();
            return _categoryList;
        }
        
        //use the category constructor then insert the newly created category into the collection
        public static void AddCategory(string categoryName)
        {
            var newCategory = new Category(categoryName);
            CategoryCollection.InsertOne(newCategory);
        }

        //both the update and delete below needs to change the according books as well
        //thus the length of the methods themselves

        public static bool DeleteCategory(string id)
        {
            //get the category name from the id, and then query the books table
            //to check if there is any books left
            //then allow for category deletion.
            var filter = Builders<Category>.Filter.Eq("_id", ObjectId.Parse(id));

            //this returns the name of the first category id matching
            var category = CategoryCollection.Find(filter).First().CategoryName;
            var count = BookCollection.CountDocuments(b => b.Category.Equals(category));

            //check if there is any books left, false if not and delete then return true otherwise
            if (count != 0) return false;
            CategoryCollection.DeleteOne(c => c.Id == ObjectId.Parse(id));
            Console.WriteLine($"Deleted category \"{category}\" successfully!");
            return true;
        }

        public static void UpdateCategory(string id, string categoryName)
        {
            //same as above, get category name and find all books matching
            var idFilter = Builders<Category>.Filter.Eq("_id", ObjectId.Parse(id));
            var category = CategoryCollection.Find(idFilter).First().CategoryName;

            //definition to change towards
            var bookUpdateDefinition = Builders<Book>.Update.Set(b => b.Category, categoryName);

            //then update all the related books.
            BookCollection.UpdateMany(b => b.Category.Equals(category), bookUpdateDefinition);

            //then update the category name.
            var updateDefinition = Builders<Category>.Update.Set(c => c.CategoryName, categoryName);
            CategoryCollection.UpdateOne(c => c.Id == ObjectId.Parse(id), updateDefinition);
        }
    }
}