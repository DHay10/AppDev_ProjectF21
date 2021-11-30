
namespace ProjectV1
{
    partial class DashboardView
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
            this.addNewStudentButton = new System.Windows.Forms.Button();
            this.searchStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewStudentButton
            // 
            this.addNewStudentButton.Location = new System.Drawing.Point(53, 77);
            this.addNewStudentButton.Name = "addNewStudentButton";
            this.addNewStudentButton.Size = new System.Drawing.Size(136, 71);
            this.addNewStudentButton.TabIndex = 0;
            this.addNewStudentButton.Text = "Add a new student";
            this.addNewStudentButton.UseVisualStyleBackColor = true;
            this.addNewStudentButton.Click += new System.EventHandler(this.addNewStudentButton_Click);
            // 
            // searchStudentButton
            // 
            this.searchStudentButton.Location = new System.Drawing.Point(322, 77);
            this.searchStudentButton.Name = "searchStudentButton";
            this.searchStudentButton.Size = new System.Drawing.Size(136, 71);
            this.searchStudentButton.TabIndex = 1;
            this.searchStudentButton.Text = "Search for a student";
            this.searchStudentButton.UseVisualStyleBackColor = true;
            this.searchStudentButton.Click += new System.EventHandler(this.searchStudentButton_Click);
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 216);
            this.Controls.Add(this.searchStudentButton);
            this.Controls.Add(this.addNewStudentButton);
            this.Name = "DashboardView";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewStudentButton;
        private System.Windows.Forms.Button searchStudentButton;
    }
}