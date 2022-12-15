using System;
using System.Windows.Forms;
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
                var loginStatus = AccountManage.Login(Email.Text, Password.Text);
                if (loginStatus == "Admin" ||
                    loginStatus == "User" ||
                    loginStatus == "Librarian")
                {
                    LoggedInClass aLoggedInClass = LoggedInClass.GetInstance(loginStatus);
                    //transition to the dashboard
                }
            }
        }

        private void RegisterHandle(object sender, EventArgs e)
        {
        }
    }
}