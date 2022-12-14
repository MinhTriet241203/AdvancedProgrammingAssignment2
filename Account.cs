using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2
{
    public class Account
    {
        private string _email;
        private string _id;
        private string _name;
        private string _password;
        protected string Class;

        protected Account(string id, string email, string fullName, string password, string @class)
        {
            _id = id;
            _email = email;
            _name = fullName;
            _password = password;
            Class = @class;
        }

        protected Account(string id, string email, string name, string password)
        {
            _id = id;
            _email = email;
            _name = name;
            _password = password;
        }

    }
}