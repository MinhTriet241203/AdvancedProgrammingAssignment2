namespace AdvancedProgrammingAssignment2
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
            this.buttonBorrowing = new FontAwesome.Sharp.IconButton();
            this.buttonAccounts = new FontAwesome.Sharp.IconButton();
            this.buttonAuthors = new FontAwesome.Sharp.IconButton();
            this.buttonBooks = new FontAwesome.Sharp.IconButton();
            this.buttonCategories = new FontAwesome.Sharp.IconButton();
            this.buttonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.buttonBorrowing);
            this.panelMenu.Controls.Add(this.buttonAccounts);
            this.panelMenu.Controls.Add(this.buttonAuthors);
            this.panelMenu.Controls.Add(this.buttonBooks);
            this.panelMenu.Controls.Add(this.buttonCategories);
            this.panelMenu.Controls.Add(this.buttonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // buttonBorrowing
            // 
            this.buttonBorrowing.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonBorrowing, "buttonBorrowing");
            this.buttonBorrowing.FlatAppearance.BorderSize = 0;
            this.buttonBorrowing.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBorrowing.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.buttonBorrowing.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonBorrowing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBorrowing.IconSize = 40;
            this.buttonBorrowing.Name = "buttonBorrowing";
            this.buttonBorrowing.UseVisualStyleBackColor = true;
            // 
            // buttonAccounts
            // 
            this.buttonAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonAccounts, "buttonAccounts");
            this.buttonAccounts.FlatAppearance.BorderSize = 0;
            this.buttonAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAccounts.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.buttonAccounts.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonAccounts.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonAccounts.IconSize = 40;
            this.buttonAccounts.Name = "buttonAccounts";
            this.buttonAccounts.UseVisualStyleBackColor = true;
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonAuthors, "buttonAuthors");
            this.buttonAuthors.FlatAppearance.BorderSize = 0;
            this.buttonAuthors.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAuthors.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.buttonAuthors.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonAuthors.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonAuthors.IconSize = 40;
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonBooks
            // 
            this.buttonBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonBooks, "buttonBooks");
            this.buttonBooks.FlatAppearance.BorderSize = 0;
            this.buttonBooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBooks.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.buttonBooks.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBooks.IconSize = 40;
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.UseVisualStyleBackColor = true;
            // 
            // buttonCategories
            // 
            this.buttonCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonCategories, "buttonCategories");
            this.buttonCategories.FlatAppearance.BorderSize = 0;
            this.buttonCategories.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCategories.IconChar = FontAwesome.Sharp.IconChar.Reorder;
            this.buttonCategories.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCategories.IconSize = 40;
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonDashboard, "buttonDashboard");
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDashboard.IconChar = FontAwesome.Sharp.IconChar.GaugeSimpleMed;
            this.buttonDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDashboard.IconSize = 40;
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Name = "panelLogo";
            // 
            // LibraryApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LibraryApp";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton buttonAccounts;
        private FontAwesome.Sharp.IconButton buttonBorrowing;

        private FontAwesome.Sharp.IconButton buttonCategories;
        private FontAwesome.Sharp.IconButton buttonBooks;
        private FontAwesome.Sharp.IconButton buttonAuthors;

        private FontAwesome.Sharp.IconButton buttonDashboard;

        private System.Windows.Forms.Panel panelLogo;

        private System.Windows.Forms.Panel panelMenu;

        #endregion
    }
}