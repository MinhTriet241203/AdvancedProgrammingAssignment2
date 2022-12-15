using System;
using System.Windows.Forms;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class ProgressForm : Form //typo here
    {
        private int _startpoint;

        public ProgressForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _startpoint += 5;
            progressBar1.Value = _startpoint;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                Hide();

                //todo: add a login form intercepting this process
                
                //Create new LibraryApp.css file to run window

                Login login = new Login();
                
                //Run LibraryApp.cs to open new window

                LibraryApp log = new LibraryApp();

                login.Show();
            }
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}