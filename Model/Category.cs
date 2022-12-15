using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AdvancedProgrammingAssignment2.Model
{
    public class Category
    {
        [BsonId] 
        internal ObjectId Id { get; set; }
        [BsonElement("categoryName")][BsonRequired]
        internal string CategoryName { get; set; }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}