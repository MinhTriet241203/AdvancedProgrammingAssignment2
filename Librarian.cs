namespace AdvancedProgrammingAssignment2
{
    public class Librarian : Account
    {
        protected Librarian(string id, string email, string fullName, string password) : base(id, email, fullName, password)
        {
            Class = "Librarian";
        }
    }
}