using System;
using System.Windows.Forms;
using AdvancedProgrammingAssignment2.Controller;
using AdvancedProgrammingAssignment2.Model;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class Login : Form
    {
        private Form _currentChildForm;
        
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
                    var authClass = LoggedInClass.GetInstance(loginStatus);
                    //todo: transition to the dashboards
                }
            }
        }

        private void LoginAccount_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}