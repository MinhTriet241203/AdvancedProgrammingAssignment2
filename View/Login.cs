using System;
using System.Windows.Forms;
using AdvancedProgrammingAssignment2.Controller;
using AdvancedProgrammingAssignment2.Model;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class Login : Form
    {

        //Fields
        
        private readonly Panel panelRegister;


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

        private void RegisterHandle(object sender, EventArgs e)
        {

            throw new System.NotImplementedException();
            // InitializeComponent().pnRegister.TabIndex = 9;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();

        }
    }
}