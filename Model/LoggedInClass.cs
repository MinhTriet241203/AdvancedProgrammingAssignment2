namespace AdvancedProgrammingAssignment2.Model
{
    public class LoggedInClass
    {
        private static LoggedInClass _accountClass;

        private static readonly object _lock = new object();

        private LoggedInClass()
        {
        }

        public string Value { get; set; }

        public static LoggedInClass GetInstance(string value)
        {
            if (_accountClass == null)
                lock (_lock)
                {
                    if (_accountClass == null)
                    {
                        _accountClass = new LoggedInClass();
                        _accountClass.Value = value;
                    }
                }

            return _accountClass;
        }
    }
}