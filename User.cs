namespace AdvancedProgrammingAssignment2
{
    public class User : Account
    {
        public User(string email, string name, string password) : base(email, name, password)
        {
            AccountClass = "User";
        }
    }
}