using System.Collections.Generic;
using System.Windows.Forms;
using PersonalLibrary.Models;


namespace PersonalLibrary
{
    partial class LoginForm
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
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(66, 77);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(188, 22);
            this.LoginInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(66, 147);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(188, 22);
            this.PasswordInput.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(66, 237);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(188, 37);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(63, 58);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(40, 16);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(63, 128);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 332);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal library - login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void SetInitialState()
        {
            this.PasswordInput.PasswordChar = '*';
        }
        private void DoLogin()
        {
            string login = LoginInput.Text;
            string password = PasswordInput.Text;
            User user = USERS.ContainsKey(login) ? USERS[login] : null; 
            if (user == null || !user.Password.Equals(password)) 
            {
                var result = MessageBox.Show("Wrong user name or password ", "Can not login",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            MainForm mainForm = new MainForm(this, user);
            mainForm.ShowDialog();
        }

        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private Dictionary<string, User> USERS = new Dictionary<string, User>()
        {
            //TODO - change to smth meaningful 
            { "1", new User("1","1",User.UserType.Administrator)},
            { "2", new User("2","2",User.UserType.Reader)}
        };
    }
}

