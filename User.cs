namespace AdvancedProgrammingAssignment2
{
    public class User : Account
    {
        public User(string email, string fullName, string password) : base(email, fullName, password)
        {
            AccountClass = "User";
        }
    }
}