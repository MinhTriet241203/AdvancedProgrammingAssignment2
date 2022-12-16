using System;
using System.Windows.Forms;
using System.Windows.Media.Converters;
using AdvancedProgrammingAssignment2.Controller;
using AdvancedProgrammingAssignment2.Model;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginHandle(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Email.Text))
            {
                var loginStatus = AuthenticationController.Login(Email.Text, Password.Text);
                if (loginStatus == "Admin" ||
                    loginStatus == "User" ||
                    loginStatus == "Librarian")
                {
                    LoggedInClass authClass = LoggedInClass.GetInstance(loginStatus);
                    //todo: transition to the dashboards
                }
            }
        }

        private void RegisterHandle(object sender, EventArgs e)
        {
        }
    }
}