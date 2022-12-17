using System;
using System.Windows.Forms;



namespace AdvancedProgrammingAssignment2.View
{
    public partial class LoginAndRegister : Form
    {
        
        private Form _currentChildForm;
        
        public LoginAndRegister()
        {
            InitializeComponent();
            OpenChildForm(new Login());
            
        }
        
        private void OpenChildForm(Form childForm)
        {
            _currentChildForm?.Close();
            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnLeft.Controls.Add(childForm);
            pnLeft.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Register());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Login());
        }
        
    }
}