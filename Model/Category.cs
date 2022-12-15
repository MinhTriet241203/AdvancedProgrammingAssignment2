using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AdvancedProgrammingAssignment2.Model
{
    public class Category
    {
        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }

        [BsonId] internal ObjectId Id { get; set; }

        [BsonElement("categoryName")]
        [BsonRequired]
        public string CategoryName { get; set; }
    }
}