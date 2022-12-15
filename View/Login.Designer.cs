using System.ComponentModel;

namespace AdvancedProgrammingAssignment2.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Email = new System.Windows.Forms.TextBox();
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
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(101, 187);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(234, 22);
            this.Email.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(469, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 417);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(101, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(101, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(101, 245);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(234, 22);
            this.Password.TabIndex = 5;
            this.Password.UseSystemPasswordChar = true; 
            // 
            // LoginAccount
            // 
            this.LoginAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAccount.Location = new System.Drawing.Point(101, 309);
            this.LoginAccount.Margin = new System.Windows.Forms.Padding(4);
            this.LoginAccount.Name = "LoginAccount";
            this.LoginAccount.Size = new System.Drawing.Size(105, 30);
            this.LoginAccount.TabIndex = 6;
            this.LoginAccount.Text = "Login";
            this.LoginAccount.UseVisualStyleBackColor = false;
            this.LoginAccount.Click += new System.EventHandler(this.LoginHandle);
            // 
            // RegisterAccount
            // 
            this.RegisterAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterAccount.Location = new System.Drawing.Point(230, 309);
            this.RegisterAccount.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterAccount.Name = "RegisterAccount";
            this.RegisterAccount.Size = new System.Drawing.Size(105, 31);
            this.RegisterAccount.TabIndex = 7;
            this.RegisterAccount.Text = "Register";
            this.RegisterAccount.UseVisualStyleBackColor = false;
            this.RegisterAccount.Click += new System.EventHandler(this.RegisterHandle);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(40, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Library Management\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(928, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegisterAccount);
            this.Controls.Add(this.LoginAccount);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Email);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

        private System.Windows.Forms.TextBox Email;

        #endregion
    }
}