using System;
using System.Windows.Forms;

namespace AdvancedProgrammingAssignment2
{
    public partial class ProgessForm : Form
    {
        public ProgessForm()
        {
            InitializeComponent();
        }

        private int startpoint = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            progressBar1.Value = startpoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                this.Hide();

                LibraryApp log = new LibraryApp();
                log.Show();
                
                
            }
            
        }

        private void ProgessForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}