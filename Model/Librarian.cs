namespace AdvancedProgrammingAssignment2.Model
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