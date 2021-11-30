
namespace ProjectV1
{
    partial class LoginView
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
            this.loginButton = new System.Windows.Forms.Button();
            this.loginL = new System.Windows.Forms.Label();
            this.usernameL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(156, 205);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(63, 30);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginL.Location = new System.Drawing.Point(163, 69);
            this.loginL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(43, 17);
            this.loginL.TabIndex = 1;
            this.loginL.Text = "Login";
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Location = new System.Drawing.Point(40, 112);
            this.usernameL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(58, 13);
            this.usernameL.TabIndex = 2;
            this.usernameL.Text = "Username:";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(40, 148);
            this.passwordL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(56, 13);
            this.passwordL.TabIndex = 3;
            this.passwordL.Text = "Password:";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(113, 109);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(196, 20);
            this.usernameTB.TabIndex = 4;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(113, 148);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(196, 20);
            this.passwordTB.TabIndex = 5;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(92, 27);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(217, 25);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Welcome to your SISD!";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 259);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.usernameL);
            this.Controls.Add(this.loginL);
            this.Controls.Add(this.loginButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginView";
            this.Text = "Vanier SISD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

