using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AdvancedProgrammingAssignment2
{
    public class Account
    {
        [BsonId] protected ObjectId Id { get; set; }
        [BsonElement("email"), BsonRequired] private string Email { get; set; }
        [BsonElement("name")] private string Name { get; set; }
        [BsonElement("password")] private string Password { get; set; }
        [BsonElement("class")] protected string AccountClass { get; set; }

        protected Account(string email, string name, string password, string accountClass)
        {
            Email = email;
            Name = name;
            Password = password;
            AccountClass = accountClass;
        }

        protected Account(string email, string name, string password)
        {
            Email = email;
            Name = name;
            Password = password;
        }

        protected void UpdatePassword(string prePassword, string newPassword)
        {
            //todo: add update password here
        }
    }
}