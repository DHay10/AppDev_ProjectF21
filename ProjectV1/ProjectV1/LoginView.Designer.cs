
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
            this.button1 = new System.Windows.Forms.Button();
            this.loginL = new System.Windows.Forms.Label();
            this.usernameL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Location = new System.Drawing.Point(350, 66);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(43, 17);
            this.loginL.TabIndex = 1;
            this.loginL.Text = "Login";
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Location = new System.Drawing.Point(137, 173);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(77, 17);
            this.usernameL.TabIndex = 2;
            this.usernameL.Text = "Username:";
            this.usernameL.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(137, 226);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(73, 17);
            this.passwordL.TabIndex = 3;
            this.passwordL.Text = "Password:";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(221, 173);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 22);
            this.usernameTB.TabIndex = 4;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(221, 223);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(100, 22);
            this.passwordTB.TabIndex = 5;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.usernameL);
            this.Controls.Add(this.loginL);
            this.Controls.Add(this.button1);
            this.Name = "LoginView";
            this.Text = "Vanier SISD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
    }
}

