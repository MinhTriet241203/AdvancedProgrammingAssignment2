using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AdvancedProgrammingAssignment2.Model
{
    public class Account
    {
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

        //setup BsonElement for database use
        [BsonId] internal ObjectId Id { get; set; }
        [BsonElement("email")] [BsonRequired] internal string Email { get; set; }
        [BsonElement("name")] internal string Name { get; set; }
        [BsonElement("password")] internal string Password { get; set; }
        [BsonElement("class")] internal string AccountClass { get; set; }

        protected void UpdatePassword(string prePassword, string newPassword)
        {
            //todo: add update password here
        }
    }
}