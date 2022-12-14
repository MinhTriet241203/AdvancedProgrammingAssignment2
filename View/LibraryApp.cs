using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class LibraryApp : Form
    {
        //Fields
        private readonly Panel _leftBorderButton;
        private IconButton _currentButton;
        private Form _currentChildForm;

        //Constructor
        public LibraryApp()
        {
            InitializeComponent();
            _leftBorderButton = new Panel();
            _leftBorderButton.Size = new Size(7, 70);
            panelMenu.Controls.Add(_leftBorderButton);
        }

        //Methods
        private void ActivateButton(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DisableButton();
                _currentButton = (IconButton)senderButton;
                _currentButton.BackColor = Color.FromArgb(204, 213, 174);
                _currentButton.ForeColor = color;
                _currentButton.IconColor = color;
                _currentButton.TextAlign = ContentAlignment.MiddleCenter;
                _currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentButton.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                _leftBorderButton.BackColor = color;
                _leftBorderButton.Location = new Point(0, _currentButton.Location.Y);
                _leftBorderButton.Visible = true;
                _leftBorderButton.BringToFront();

                //Title bar
                iconButtonTitleBar.IconChar = _currentButton.IconChar;
                iconButtonTitleBar.IconColor = _currentButton.IconColor;
                iconButtonTitleBar.Text = _currentButton.Text;
            }
        }

        private void DisableButton()
        {
            if (_currentButton != null)
            {
                _currentButton.BackColor = Color.FromArgb(242, 233, 228);
                _currentButton.ForeColor = Color.FromArgb(31, 30, 68);
                _currentButton.IconColor = Color.FromArgb(31, 30, 68);
                _currentButton.TextAlign = ContentAlignment.MiddleLeft;
                _currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            _leftBorderButton.Visible = false;

            //Title bar
            iconButtonTitleBar.IconChar = IconChar.Home;
            iconButtonTitleBar.IconColor = RgbColors.Color6;
            iconButtonTitleBar.Text = @"Home";
        }

        private void OpenChildForm(Form childForm)
        {
            _currentChildForm?.Close();
            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHub.Controls.Add(childForm);
            panelHub.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Button events
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color1);
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color2);
            OpenChildForm(new CategoryForm());
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color3);
            OpenChildForm(new BookForm());
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color4);
        }

        private void buttonLibrarians_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color5);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void LibraryApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Struct
        private struct RgbColors
        {
            public static readonly Color Color1 = Color.FromArgb(172, 126, 241);
            public static readonly Color Color2 = Color.FromArgb(249, 118, 176);
            public static readonly Color Color3 = Color.FromArgb(253, 138, 114);
            public static readonly Color Color4 = Color.FromArgb(95, 77, 221);
            public static readonly Color Color5 = Color.FromArgb(249, 88, 155);
            public static readonly Color Color6 = Color.FromArgb(24, 161, 251);
        }

        //todo: implement a logout button that uses this
        ////code for logging out of the application since the class are used as singleton,
        ////we had to restart the application essentially
        // Application.Restart();
        // Environment.Exit(0);
    }
}