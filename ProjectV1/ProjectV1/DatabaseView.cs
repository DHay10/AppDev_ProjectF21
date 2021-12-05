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
            Student currentStudent = (Student) studentTableDGV.CurrentRow.DataBoundItem;
            idTB.Text = currentStudent.StudentID.ToString();
            fNameTB.Text = currentStudent.FName;
            lNameTB.Text = currentStudent.LName;
            dobTB.Text = currentStudent.Dob.ToString();
            phoneNumTB.Text = currentStudent.PhoneNum;
            addressTB.Text = currentStudent.Address;
            postalCodeTB.Text = currentStudent.PostalCode;
            emergencyNumTB.Text = currentStudent.EmergencyNum;
            fGuardianNameTB.Text = currentStudent.Parent1Name;
            sGuardianNameTB.Text = currentStudent.Parent2Name;
        }

        private void studentTableDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Student currentStudent = (Student)studentTableDGV.CurrentRow.DataBoundItem;
            idTB.Text = string.Format("{0:D8}", currentStudent.StudentID);
            fNameTB.Text = currentStudent.FName;
            lNameTB.Text = currentStudent.LName;
            dobTB.Text = currentStudent.Dob.ToString("d");
            phoneNumTB.Text = currentStudent.PhoneNum;
            addressTB.Text = currentStudent.Address;
            postalCodeTB.Text = currentStudent.PostalCode;
            emergencyNumTB.Text = currentStudent.EmergencyNum;
            fGuardianNameTB.Text = currentStudent.Parent1Name;
            sGuardianNameTB.Text = currentStudent.Parent2Name;
        }
    }
}
