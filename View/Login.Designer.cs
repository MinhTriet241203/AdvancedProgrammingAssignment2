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
            this.pnRegister = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginAccount = new System.Windows.Forms.Button();
            this.RegisterAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnRegister.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(143, 123);
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
            this.panel1.Location = new System.Drawing.Point(387, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 289);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnRegister
            // 
            this.pnRegister.Controls.Add(this.textBox3);
            this.pnRegister.Controls.Add(this.label9);
            this.pnRegister.Controls.Add(this.label5);
            this.pnRegister.Controls.Add(this.button1);
            this.pnRegister.Controls.Add(this.label6);
            this.pnRegister.Controls.Add(this.button2);
            this.pnRegister.Controls.Add(this.textBox1);
            this.pnRegister.Controls.Add(this.label7);
            this.pnRegister.Controls.Add(this.textBox2);
            this.pnRegister.Controls.Add(this.label8);
            this.pnRegister.Location = new System.Drawing.Point(3, 3);
            this.pnRegister.Name = "pnRegister";
            this.pnRegister.Size = new System.Drawing.Size(393, 289);
            this.pnRegister.TabIndex = 9;
            this.pnRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(49, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(60, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Library Management\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(194, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 41);
            this.label6.TabIndex = 2;
            this.label6.Text = "Register";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(49, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(49, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(49, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Email";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(49, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(49, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(143, 160);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(130, 20);
            this.Password.TabIndex = 5;
            // 
            // LoginAccount
            // 
            this.LoginAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAccount.Location = new System.Drawing.Point(49, 199);
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
            this.RegisterAccount.Location = new System.Drawing.Point(194, 199);
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
            this.label4.Location = new System.Drawing.Point(35, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Library Management\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.pnRegister);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Controls.Add(this.label4);
            this.pnLogin.Controls.Add(this.RegisterAccount);
            this.pnLogin.Controls.Add(this.LoginAccount);
            this.pnLogin.Controls.Add(this.UserName);
            this.pnLogin.Controls.Add(this.label3);
            this.pnLogin.Controls.Add(this.Password);
            this.pnLogin.Controls.Add(this.label2);
            this.pnLogin.Location = new System.Drawing.Point(-1, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(394, 320);
            this.pnLogin.TabIndex = 8;
            this.pnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 289);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login Account";
            this.pnRegister.ResumeLayout(false);
            this.pnRegister.PerformLayout();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Panel pnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Panel pnLogin;

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