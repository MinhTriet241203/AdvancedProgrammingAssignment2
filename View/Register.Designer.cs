using System.ComponentModel;

namespace AdvancedProgrammingAssignment2.View
{
    partial class Register
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
            this.Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(158, 149);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(130, 20);
            this.Email.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(36, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(36, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Library Management\r\n";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(209, 218);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(79, 25);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 41);
            this.label6.TabIndex = 2;
            this.label6.Text = "Register";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(158, 108);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(130, 20);
            this.Name.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(36, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(158, 190);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(130, 20);
            this.Password.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(36, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Email";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 255);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label6);
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox Name;

        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label6;
    
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label8;

        #endregion
    }
}