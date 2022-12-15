using System;
using System.Windows.Forms;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class ProgressForm : Form //typo here
    {
        private int startpoint;

        public ProgressForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            progressBar1.Value = startpoint;
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

                log.Show();
            }
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}