
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
            this.studentDBDataSet = new ProjectV1.StudentDBDataSet();
            this.studentTableAdapter = new ProjectV1.StudentDBDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new ProjectV1.StudentDBDataSetTableAdapters.TableAdapterManager();
            this.studentDGView = new System.Windows.Forms.DataGridView();
            this.refreshB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentDBDataSet;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectV1.StudentDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentDGView
            // 
            this.studentDGView.AllowUserToAddRows = false;
            this.studentDGView.AllowUserToDeleteRows = false;
            this.studentDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDGView.Location = new System.Drawing.Point(12, 41);
            this.studentDGView.Name = "studentDGView";
            this.studentDGView.ReadOnly = true;
            this.studentDGView.Size = new System.Drawing.Size(1120, 473);
            this.studentDGView.TabIndex = 0;
            // 
            // refreshB
            // 
            this.refreshB.Location = new System.Drawing.Point(1057, 12);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(75, 23);
            this.refreshB.TabIndex = 1;
            this.refreshB.Text = "Refresh";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // DatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 526);
            this.Controls.Add(this.refreshB);
            this.Controls.Add(this.studentDGView);
            this.Name = "DatabaseView";
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private StudentDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView studentDGView;
        private System.Windows.Forms.Button refreshB;
    }
}