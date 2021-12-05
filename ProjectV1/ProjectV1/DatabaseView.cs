using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectV1
{
    public partial class DatabaseView : Form
    {
        BindingSource bs = new BindingSource();
        public DatabaseView()
        {
            InitializeComponent();
        }

        private void DatabaseView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDBDataSet.Student);
            bs.DataSource = typeof(Student);
            studentTableDGV.DataSource = bs;
            foreach (Student s in DBSystem.Students)
            {
                bs.Add(s);
            }
            studentTableDGV.DataSource = bs;
            studentTableDGV.AutoGenerateColumns = true;
            studentTableDGV.Columns["StudentID"].HeaderText = "Student ID";
            studentTableDGV.Columns["FName"].HeaderText = "First Name";
            studentTableDGV.Columns["LName"].HeaderText = "Last Name";
            studentTableDGV.Columns["PhoneNum"].HeaderText = "Phone Number";
            studentTableDGV.Columns["Dob"].Visible = false;
            studentTableDGV.Columns["Address"].Visible = false;
            studentTableDGV.Columns["PostalCode"].Visible = false;
            studentTableDGV.Columns["EmergencyNum"].Visible = false;
            studentTableDGV.Columns["Parent1Name"].Visible = false;
            studentTableDGV.Columns["Parent2Name"].Visible = false;
        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            bs.Clear();
            foreach (Student s in DBSystem.Students)
            {
                bs.Add(s);
            }
            studentTableDGV.Refresh();
        }

        private void studentTableDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Hide();
            //StudentFileView studentFile = new StudentFileView(this.bs.Current);
            //mainMenu.FormClosed += (s, args) => this.Close();
            //mainMenu.Show();
        }
    }
}
