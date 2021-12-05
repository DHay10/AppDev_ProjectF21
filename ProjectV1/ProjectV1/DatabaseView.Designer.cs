
namespace ProjectV1
{
    partial class DatabaseView
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
            this.components = new System.ComponentModel.Container();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.studentTableDGV = new System.Windows.Forms.DataGridView();
            this.infoPreviewP = new System.Windows.Forms.Panel();
            this.nextB = new System.Windows.Forms.Button();
            this.prevB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.sGuardianNameTB = new System.Windows.Forms.TextBox();
            this.fGuardianNameTB = new System.Windows.Forms.TextBox();
            this.emergencyNumTB = new System.Windows.Forms.TextBox();
            this.postalCodeTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.phoneNumTB = new System.Windows.Forms.TextBox();
            this.dobTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.secGuardianNameL = new System.Windows.Forms.Label();
            this.firstGuardianNameL = new System.Windows.Forms.Label();
            this.idL = new System.Windows.Forms.Label();
            this.emergencyNum = new System.Windows.Forms.Label();
            this.postalCodeL = new System.Windows.Forms.Label();
            this.addressL = new System.Windows.Forms.Label();
            this.phoneNumL = new System.Windows.Forms.Label();
            this.dobL = new System.Windows.Forms.Label();
            this.lNameL = new System.Windows.Forms.Label();
            this.fNameL = new System.Windows.Forms.Label();
            this.titlePreviewL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableDGV)).BeginInit();
            this.infoPreviewP.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // refreshB
            // 
            this.refreshB.Location = new System.Drawing.Point(13, 13);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(75, 23);
            this.refreshB.TabIndex = 2;
            this.refreshB.Text = "Refresh";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // studentTableDGV
            // 
            this.studentTableDGV.AllowUserToAddRows = false;
            this.studentTableDGV.AllowUserToDeleteRows = false;
            this.studentTableDGV.AllowUserToResizeRows = false;
            this.studentTableDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studentTableDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentTableDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTableDGV.Location = new System.Drawing.Point(13, 42);
            this.studentTableDGV.MultiSelect = false;
            this.studentTableDGV.Name = "studentTableDGV";
            this.studentTableDGV.ReadOnly = true;
            this.studentTableDGV.Size = new System.Drawing.Size(667, 407);
            this.studentTableDGV.TabIndex = 5;
            this.studentTableDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTableDGV_CellContentDoubleClick);
            this.studentTableDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentTableDGV_RowHeaderMouseClick);
            this.studentTableDGV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentTableDGV_RowHeaderMouseClick);
            // 
            // infoPreviewP
            // 
            this.infoPreviewP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPreviewP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPreviewP.Controls.Add(this.nextB);
            this.infoPreviewP.Controls.Add(this.prevB);
            this.infoPreviewP.Controls.Add(this.updateB);
            this.infoPreviewP.Controls.Add(this.sGuardianNameTB);
            this.infoPreviewP.Controls.Add(this.fGuardianNameTB);
            this.infoPreviewP.Controls.Add(this.emergencyNumTB);
            this.infoPreviewP.Controls.Add(this.postalCodeTB);
            this.infoPreviewP.Controls.Add(this.addressTB);
            this.infoPreviewP.Controls.Add(this.phoneNumTB);
            this.infoPreviewP.Controls.Add(this.dobTB);
            this.infoPreviewP.Controls.Add(this.lNameTB);
            this.infoPreviewP.Controls.Add(this.fNameTB);
            this.infoPreviewP.Controls.Add(this.idTB);
            this.infoPreviewP.Controls.Add(this.secGuardianNameL);
            this.infoPreviewP.Controls.Add(this.firstGuardianNameL);
            this.infoPreviewP.Controls.Add(this.idL);
            this.infoPreviewP.Controls.Add(this.emergencyNum);
            this.infoPreviewP.Controls.Add(this.postalCodeL);
            this.infoPreviewP.Controls.Add(this.addressL);
            this.infoPreviewP.Controls.Add(this.phoneNumL);
            this.infoPreviewP.Controls.Add(this.dobL);
            this.infoPreviewP.Controls.Add(this.lNameL);
            this.infoPreviewP.Controls.Add(this.fNameL);
            this.infoPreviewP.Controls.Add(this.titlePreviewL);
            this.infoPreviewP.Location = new System.Drawing.Point(687, 12);
            this.infoPreviewP.Name = "infoPreviewP";
            this.infoPreviewP.Size = new System.Drawing.Size(545, 437);
            this.infoPreviewP.TabIndex = 6;
            // 
            // nextB
            // 
            this.nextB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextB.Location = new System.Drawing.Point(85, 408);
            this.nextB.Name = "nextB";
            this.nextB.Size = new System.Drawing.Size(75, 23);
            this.nextB.TabIndex = 23;
            this.nextB.Text = "Next >";
            this.nextB.UseVisualStyleBackColor = true;
            this.nextB.Click += new System.EventHandler(this.nextB_Click);
            // 
            // prevB
            // 
            this.prevB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prevB.Location = new System.Drawing.Point(4, 408);
            this.prevB.Name = "prevB";
            this.prevB.Size = new System.Drawing.Size(75, 23);
            this.prevB.TabIndex = 22;
            this.prevB.Text = "< Previous";
            this.prevB.UseVisualStyleBackColor = true;
            this.prevB.Click += new System.EventHandler(this.prevB_Click);
            // 
            // updateB
            // 
            this.updateB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateB.Location = new System.Drawing.Point(465, 409);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(75, 23);
            this.updateB.TabIndex = 21;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // sGuardianNameTB
            // 
            this.sGuardianNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sGuardianNameTB.Location = new System.Drawing.Point(277, 234);
            this.sGuardianNameTB.Name = "sGuardianNameTB";
            this.sGuardianNameTB.Size = new System.Drawing.Size(263, 20);
            this.sGuardianNameTB.TabIndex = 20;
            // 
            // fGuardianNameTB
            // 
            this.fGuardianNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGuardianNameTB.Location = new System.Drawing.Point(277, 208);
            this.fGuardianNameTB.Name = "fGuardianNameTB";
            this.fGuardianNameTB.Size = new System.Drawing.Size(263, 20);
            this.fGuardianNameTB.TabIndex = 19;
            // 
            // emergencyNumTB
            // 
            this.emergencyNumTB.Location = new System.Drawing.Point(277, 182);
            this.emergencyNumTB.Name = "emergencyNumTB";
            this.emergencyNumTB.Size = new System.Drawing.Size(84, 20);
            this.emergencyNumTB.TabIndex = 18;
            // 
            // postalCodeTB
            // 
            this.postalCodeTB.Location = new System.Drawing.Point(277, 156);
            this.postalCodeTB.Name = "postalCodeTB";
            this.postalCodeTB.Size = new System.Drawing.Size(84, 20);
            this.postalCodeTB.TabIndex = 17;
            // 
            // addressTB
            // 
            this.addressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTB.Location = new System.Drawing.Point(277, 130);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(263, 20);
            this.addressTB.TabIndex = 16;
            // 
            // phoneNumTB
            // 
            this.phoneNumTB.Location = new System.Drawing.Point(277, 104);
            this.phoneNumTB.Name = "phoneNumTB";
            this.phoneNumTB.Size = new System.Drawing.Size(84, 20);
            this.phoneNumTB.TabIndex = 15;
            // 
            // dobTB
            // 
            this.dobTB.Location = new System.Drawing.Point(277, 78);
            this.dobTB.Name = "dobTB";
            this.dobTB.ReadOnly = true;
            this.dobTB.Size = new System.Drawing.Size(84, 20);
            this.dobTB.TabIndex = 14;
            // 
            // lNameTB
            // 
            this.lNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNameTB.Location = new System.Drawing.Point(277, 52);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.ReadOnly = true;
            this.lNameTB.Size = new System.Drawing.Size(263, 20);
            this.lNameTB.TabIndex = 13;
            // 
            // fNameTB
            // 
            this.fNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fNameTB.Location = new System.Drawing.Point(277, 26);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.ReadOnly = true;
            this.fNameTB.Size = new System.Drawing.Size(263, 20);
            this.fNameTB.TabIndex = 12;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(31, 26);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 11;
            // 
            // secGuardianNameL
            // 
            this.secGuardianNameL.AutoSize = true;
            this.secGuardianNameL.Location = new System.Drawing.Point(140, 237);
            this.secGuardianNameL.Name = "secGuardianNameL";
            this.secGuardianNameL.Size = new System.Drawing.Size(131, 13);
            this.secGuardianNameL.TabIndex = 10;
            this.secGuardianNameL.Text = "Second Guardian\'s Name:";
            // 
            // firstGuardianNameL
            // 
            this.firstGuardianNameL.AutoSize = true;
            this.firstGuardianNameL.Location = new System.Drawing.Point(140, 211);
            this.firstGuardianNameL.Name = "firstGuardianNameL";
            this.firstGuardianNameL.Size = new System.Drawing.Size(110, 13);
            this.firstGuardianNameL.TabIndex = 9;
            this.firstGuardianNameL.Text = "First Guardian\'s Name";
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Location = new System.Drawing.Point(4, 29);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(21, 13);
            this.idL.TabIndex = 8;
            this.idL.Text = "ID:";
            // 
            // emergencyNum
            // 
            this.emergencyNum.AutoSize = true;
            this.emergencyNum.Location = new System.Drawing.Point(140, 185);
            this.emergencyNum.Name = "emergencyNum";
            this.emergencyNum.Size = new System.Drawing.Size(103, 13);
            this.emergencyNum.TabIndex = 7;
            this.emergencyNum.Text = "Emercency Number:";
            // 
            // postalCodeL
            // 
            this.postalCodeL.AutoSize = true;
            this.postalCodeL.Location = new System.Drawing.Point(140, 159);
            this.postalCodeL.Name = "postalCodeL";
            this.postalCodeL.Size = new System.Drawing.Size(67, 13);
            this.postalCodeL.TabIndex = 6;
            this.postalCodeL.Text = "Postal Code:";
            // 
            // addressL
            // 
            this.addressL.AutoSize = true;
            this.addressL.Location = new System.Drawing.Point(140, 133);
            this.addressL.Name = "addressL";
            this.addressL.Size = new System.Drawing.Size(48, 13);
            this.addressL.TabIndex = 5;
            this.addressL.Text = "Address:";
            // 
            // phoneNumL
            // 
            this.phoneNumL.AutoSize = true;
            this.phoneNumL.Location = new System.Drawing.Point(140, 107);
            this.phoneNumL.Name = "phoneNumL";
            this.phoneNumL.Size = new System.Drawing.Size(81, 13);
            this.phoneNumL.TabIndex = 4;
            this.phoneNumL.Text = "Phone Number:";
            // 
            // dobL
            // 
            this.dobL.AutoSize = true;
            this.dobL.Location = new System.Drawing.Point(140, 81);
            this.dobL.Name = "dobL";
            this.dobL.Size = new System.Drawing.Size(71, 13);
            this.dobL.TabIndex = 3;
            this.dobL.Text = "Date Of Birth:";
            // 
            // lNameL
            // 
            this.lNameL.AutoSize = true;
            this.lNameL.Location = new System.Drawing.Point(140, 55);
            this.lNameL.Name = "lNameL";
            this.lNameL.Size = new System.Drawing.Size(61, 13);
            this.lNameL.TabIndex = 2;
            this.lNameL.Text = "Last Name:";
            // 
            // fNameL
            // 
            this.fNameL.AutoSize = true;
            this.fNameL.Location = new System.Drawing.Point(140, 29);
            this.fNameL.Name = "fNameL";
            this.fNameL.Size = new System.Drawing.Size(60, 13);
            this.fNameL.TabIndex = 1;
            this.fNameL.Text = "First Name:";
            // 
            // titlePreviewL
            // 
            this.titlePreviewL.AutoSize = true;
            this.titlePreviewL.Location = new System.Drawing.Point(4, 9);
            this.titlePreviewL.Name = "titlePreviewL";
            this.titlePreviewL.Size = new System.Drawing.Size(66, 13);
            this.titlePreviewL.TabIndex = 0;
            this.titlePreviewL.Text = "Student File:";
            // 
            // DatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1244, 461);
            this.Controls.Add(this.infoPreviewP);
            this.Controls.Add(this.studentTableDGV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.refreshB);
            this.MinimumSize = new System.Drawing.Size(1260, 500);
            this.Name = "DatabaseView";
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableDGV)).EndInit();
            this.infoPreviewP.ResumeLayout(false);
            this.infoPreviewP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button refreshB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView studentTableDGV;
        private System.Windows.Forms.Panel infoPreviewP;
        private System.Windows.Forms.Label titlePreviewL;
        private System.Windows.Forms.TextBox sGuardianNameTB;
        private System.Windows.Forms.TextBox fGuardianNameTB;
        private System.Windows.Forms.TextBox emergencyNumTB;
        private System.Windows.Forms.TextBox postalCodeTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox phoneNumTB;
        private System.Windows.Forms.TextBox dobTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label secGuardianNameL;
        private System.Windows.Forms.Label firstGuardianNameL;
        private System.Windows.Forms.Label idL;
        private System.Windows.Forms.Label emergencyNum;
        private System.Windows.Forms.Label postalCodeL;
        private System.Windows.Forms.Label addressL;
        private System.Windows.Forms.Label phoneNumL;
        private System.Windows.Forms.Label dobL;
        private System.Windows.Forms.Label lNameL;
        private System.Windows.Forms.Label fNameL;
        private System.Windows.Forms.Button nextB;
        private System.Windows.Forms.Button prevB;
        private System.Windows.Forms.Button updateB;
    }
}