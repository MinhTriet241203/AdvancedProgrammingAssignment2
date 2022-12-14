using MongoDB.Bson;

namespace AdvancedProgrammingAssignment2
{
    public class Admin : Account
    {
        protected internal Admin(string email, string fullName, string password) : base(email, fullName, password)
        {
            AccountClass = "Admin";
        }
    }
}