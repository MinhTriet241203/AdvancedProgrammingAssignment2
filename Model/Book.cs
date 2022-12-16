using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AdvancedProgrammingAssignment2.Model
{
    public class Book
    {
        [BsonId] public ObjectId Id;

        public Book(string isbn, string bookName, string category, string author, string image)
        {
            Isbn = isbn;
            BookName = bookName;
            Category = category;
            Author = author;
            Image = image;
            BorrowState = "Available";
        }

        [BsonElement("isbn")] public string Isbn { get; set; }
        [BsonElement("bookName")] public string BookName { get; set; }
        [BsonElement("category")] public string Category { get; set; }
        [BsonElement("author")] public string Author { get; set; }
        [BsonElement("image")] public string Image { get; set; }
        [BsonElement("availability")] public string BorrowState { get; set; }
    }
}