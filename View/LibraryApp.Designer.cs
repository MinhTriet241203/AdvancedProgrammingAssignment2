using System;
using System.ComponentModel;

namespace AdvancedProgrammingAssignment2.View
{
    partial class LibraryApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryApp));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLibrarians = new FontAwesome.Sharp.IconButton();
            this.buttonAuthors = new FontAwesome.Sharp.IconButton();
            this.buttonBooks = new FontAwesome.Sharp.IconButton();
            this.buttonCategories = new FontAwesome.Sharp.IconButton();
            this.buttonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.iconButtonTitleBar = new FontAwesome.Sharp.IconButton();
            this.panelHub = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.panelMenu.Controls.Add(this.buttonLibrarians);
            this.panelMenu.Controls.Add(this.buttonAuthors);
            this.panelMenu.Controls.Add(this.buttonBooks);
            this.panelMenu.Controls.Add(this.buttonCategories);
            this.panelMenu.Controls.Add(this.buttonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // buttonLibrarians
            // 
            this.buttonLibrarians.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonLibrarians, "buttonLibrarians");
            this.buttonLibrarians.FlatAppearance.BorderSize = 0;
            this.buttonLibrarians.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonLibrarians.IconChar = FontAwesome.Sharp.IconChar.PersonMilitaryPointing;
            this.buttonLibrarians.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonLibrarians.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonLibrarians.IconSize = 40;
            this.buttonLibrarians.Name = "buttonLibrarians";
            this.buttonLibrarians.UseVisualStyleBackColor = true;
            this.buttonLibrarians.Click += new System.EventHandler(this.buttonLibrarians_Click);
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonAuthors, "buttonAuthors");
            this.buttonAuthors.FlatAppearance.BorderSize = 0;
            this.buttonAuthors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonAuthors.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.buttonAuthors.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonAuthors.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonAuthors.IconSize = 40;
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            this.buttonAuthors.Click += new System.EventHandler(this.buttonAuthors_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.buttonBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonBooks, "buttonBooks");
            this.buttonBooks.FlatAppearance.BorderSize = 0;
            this.buttonBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonBooks.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.buttonBooks.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBooks.IconSize = 40;
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.buttonCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonCategories, "buttonCategories");
            this.buttonCategories.FlatAppearance.BorderSize = 0;
            this.buttonCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonCategories.IconChar = FontAwesome.Sharp.IconChar.Reorder;
            this.buttonCategories.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCategories.IconSize = 40;
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.UseVisualStyleBackColor = false;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonDashboard, "buttonDashboard");
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonDashboard.IconChar = FontAwesome.Sharp.IconChar.GaugeSimpleMed;
            this.buttonDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDashboard.IconSize = 40;
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panelLogo
            // 
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.ForeColor = System.Drawing.Color.Black;
            this.panelLogo.Name = "panelLogo";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // iconButtonTitleBar
            // 
            this.iconButtonTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconButtonTitleBar.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.iconButtonTitleBar, "iconButtonTitleBar");
            this.iconButtonTitleBar.FlatAppearance.BorderSize = 0;
            this.iconButtonTitleBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconButtonTitleBar.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonTitleBar.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonTitleBar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.iconButtonTitleBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTitleBar.IconSize = 50;
            this.iconButtonTitleBar.Name = "iconButtonTitleBar";
            this.iconButtonTitleBar.UseVisualStyleBackColor = false;
            // 
            // panelHub
            // 
            resources.ApplyResources(this.panelHub, "panelHub");
            this.panelHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelHub.Name = "panelHub";
            // 
            // LibraryApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.panelHub);
            this.Controls.Add(this.iconButtonTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LibraryApp";
            this.Closed += new System.EventHandler(this.Form_Close);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHub;

        private FontAwesome.Sharp.IconButton iconButtonTitleBar;

        private System.Windows.Forms.Panel logo;
        
        private FontAwesome.Sharp.IconButton buttonLibrarians;
        private System.Windows.Forms.Panel panelLogo;

        private FontAwesome.Sharp.IconButton buttonCategories;
        private FontAwesome.Sharp.IconButton buttonBooks;
        private FontAwesome.Sharp.IconButton buttonAuthors;

        private FontAwesome.Sharp.IconButton buttonDashboard;

        private System.Windows.Forms.Panel panelMenu;

        #endregion
    }
}