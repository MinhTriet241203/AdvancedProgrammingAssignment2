namespace AdvancedProgrammingAssignment2
{
    public class User : Account
    {
        public User(string id, string email, string fullName, string password) : base(id, email, fullName, password)
        {
            Class = "User";
        }
    }
}