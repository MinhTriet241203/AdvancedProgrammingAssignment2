using System.ComponentModel;

namespace AdvancedProgrammingAssignment2.View
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.UserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginAccount = new System.Windows.Forms.Button();
            this.RegisterAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(152, 102);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(130, 20);
            this.UserName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(352, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 339);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(76, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(76, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(152, 138);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(130, 20);
            this.Password.TabIndex = 5;
            // 
            // LoginAccount
            // 
            this.LoginAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAccount.Location = new System.Drawing.Point(76, 191);
            this.LoginAccount.Name = "LoginAccount";
            this.LoginAccount.Size = new System.Drawing.Size(79, 24);
            this.LoginAccount.TabIndex = 6;
            this.LoginAccount.Text = "Login";
            this.LoginAccount.UseVisualStyleBackColor = false;
            this.LoginAccount.Click += new System.EventHandler(this.LoginHandle);
            // 
            // RegisterAccount
            // 
            this.RegisterAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterAccount.Location = new System.Drawing.Point(203, 190);
            this.RegisterAccount.Name = "RegisterAccount";
            this.RegisterAccount.Size = new System.Drawing.Size(79, 25);
            this.RegisterAccount.TabIndex = 7;
            this.RegisterAccount.Text = "Register";
            this.RegisterAccount.UseVisualStyleBackColor = false;
            this.RegisterAccount.Click += new System.EventHandler(this.RegisterHandle);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(30, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Library Management\r\n";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegisterAccount);
            this.Controls.Add(this.LoginAccount);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserName);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login Account";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button LoginAccount;

        private System.Windows.Forms.Button RegisterAccount;

        private System.Windows.Forms.TextBox Password;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox UserName;

        #endregion
    }
}