﻿using System;
using System.Windows.Forms;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class ProgessForm : Form //typo here
    {
        private int startpoint;

        public ProgessForm()
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


                //Create new LibraryApp.css file to run window
                login log = new login();
                
                //Run LibraryApp.cs to open new window
                log.Show();
            }
        }

        private void ProgessForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}