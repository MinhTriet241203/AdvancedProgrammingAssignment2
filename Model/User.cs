namespace AdvancedProgrammingAssignment2.Model
{
    public class User : Account
    {
        protected internal User(string email, string name, string password) : base(email, name, password)
        {
            AccountClass = "User";
        }
    }
}