using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class LibraryApp : Form
    {
        private string _activeTab;
        private string _previousTab;
        
        public LibraryApp()
        {
            InitializeComponent();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            _activeTab = "Dashboard";
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            _activeTab = "Categories";
        }
    }
}