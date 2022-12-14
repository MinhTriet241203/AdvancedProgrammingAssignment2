namespace AdvancedProgrammingAssignment2
{
    public class Admin : Account
    {
        protected Admin(string id, string email, string fullName, string password) : base(id, email, fullName, password)
        {
            Class = "Admin";
        }
    }
}