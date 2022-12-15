using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AdvancedProgrammingAssignment2.Model
{
    public class Book
    {
        [BsonId] internal ObjectId Id;

        protected Book(string isbn, string bookName, string category, string author, string image)
        {
            Isbn = isbn;
            BookName = bookName;
            Category = category;
            Author = author;
            Image = image;
            Availability = "Available";
        }

        [BsonElement("isbn")] internal string Isbn { get; set; }
        [BsonElement("bookName")] internal string BookName { get; set; }
        [BsonElement("category")] internal string Category { get; set; }
        [BsonElement("author")] internal string Author { get; set; }
        [BsonElement("image")] internal string Image { get; set; }
        [BsonElement("availability")] internal string Availability { get; set; }
    }
}