using MongoDB.Bson;

namespace AdvancedProgrammingAssignment2
{
    public class Librarian : Account
    {
        protected internal Librarian(string email, string fullName, string password) : base(email, fullName,
            password)
        {
            AccountClass = "Librarian";
        }
    }
}