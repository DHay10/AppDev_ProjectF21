
namespace ProjectV1
{
    partial class NewStudentView
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
            this.usernameL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.loginL = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.submitB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameL.Location = new System.Drawing.Point(32, 155);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(137, 29);
            this.usernameL.TabIndex = 0;
            this.usernameL.Text = "Username:";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordL.Location = new System.Drawing.Point(32, 185);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(131, 29);
            this.passwordL.TabIndex = 1;
            this.passwordL.Text = "Password:";
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginL.Location = new System.Drawing.Point(227, 66);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(75, 29);
            this.loginL.TabIndex = 2;
            this.loginL.Text = "Login";
            this.loginL.Click += new System.EventHandler(this.label3_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(175, 162);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(366, 22);
            this.usernameTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(175, 193);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(366, 22);
            this.passwordTB.TabIndex = 4;
            // 
            // submitB
            // 
            this.submitB.Location = new System.Drawing.Point(213, 264);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(104, 40);
            this.submitB.TabIndex = 5;
            this.submitB.Text = "Submit";
            this.submitB.UseVisualStyleBackColor = true;
            // 
            // NewStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 372);
            this.Controls.Add(this.submitB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.loginL);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.usernameL);
            this.Name = "NewStudentView";
            this.Text = "NewStudentView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button submitB;
    }
}