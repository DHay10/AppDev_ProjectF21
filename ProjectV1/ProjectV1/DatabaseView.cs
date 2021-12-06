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
            DataGridViewColumn columnToSort = studentTableDGV.Columns["StudentID"];
            studentTableDGV.Rows[0].Selected = true;
            rowIdx = studentTableDGV.SelectedRows[0].Index;
            Student currentStudent = (Student)studentTableDGV.Rows[rowIdx].DataBoundItem;
            displayFile(currentStudent);
        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            refreshView();
        }

        private void refreshView()
        {
            bs.Clear();
            foreach (Student s in DBSystem.Students)
            {
                bs.Add(s);
            }
            studentTableDGV.Refresh();
            studentTableDGV.Rows[0].Selected = true;
            rowIdx = studentTableDGV.SelectedRows[0].Index;
            Student currentStudent = (Student)studentTableDGV.Rows[rowIdx].DataBoundItem;
            displayFile(currentStudent);
        }

        int rowIdx;
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
            displayFile(currentStudent);
        }

        private void prevB_Click(object sender, EventArgs e)
        {
            rowIdx = studentTableDGV.SelectedRows[0].Index;
            if (rowIdx > 0) {
                studentTableDGV.Rows[--rowIdx].Selected = true;
                Student currentStudent = (Student) studentTableDGV.SelectedRows[0].DataBoundItem;
                displayFile(currentStudent);
            }
            else
            {
                rowIdx = studentTableDGV.RowCount - 1;
                studentTableDGV.Rows[rowIdx].Selected = true;
                Student currentStudent = (Student) studentTableDGV.SelectedRows[0].DataBoundItem;
                displayFile(currentStudent);
            }
        }

        private void nextB_Click(object sender, EventArgs e)
        {
            rowIdx = studentTableDGV.SelectedRows[0].Index;
            if (rowIdx < studentTableDGV.RowCount - 1)
            {
                studentTableDGV.Rows[++rowIdx].Selected = true;
                Student currentStudent = (Student) studentTableDGV.SelectedRows[0].DataBoundItem;
                displayFile(currentStudent);
            }
            else
            {
                rowIdx = 0;
                studentTableDGV.Rows[rowIdx].Selected = true;
                Student currentStudent = (Student) studentTableDGV.SelectedRows[0].DataBoundItem;
                displayFile(currentStudent);
            }
        }

        private void displayFile(Student currentStudent)
        {
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

        private void updateB_Click(object sender, EventArgs e)
        {
            Student currentStudent = (Student)studentTableDGV.SelectedRows[0].DataBoundItem;
            currentStudent.PhoneNum = phoneNumTB.Text;
            currentStudent.Address = addressTB.Text;
            currentStudent.PostalCode = postalCodeTB.Text;
            currentStudent.EmergencyNum = emergencyNumTB.Text;
            currentStudent.Parent1Name = fGuardianNameTB.Text;
            currentStudent.Parent2Name = sGuardianNameTB.Text;
            DBSystem.updateCSVFile();
            studentTableDGV.Refresh();
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            CurrencyManager cM = (CurrencyManager)BindingContext[studentTableDGV.DataSource];
            cM.SuspendBinding();
            if (searchTB.Text == "")
            {
                foreach (DataGridViewRow row in studentTableDGV.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            foreach (DataGridViewRow row in studentTableDGV.Rows)
            {
                if (studentIDFilterRB.Checked)
                {
                    int a;
                    if (!Int32.TryParse(searchTB.Text, out a))
                    {
                        MessageBox.Show("Please enter only numbers.");
                        searchTB.Text = "";
                        return;
                    } 
                    else
                    {
                        if (((Student)row.DataBoundItem).StudentID == Int32.Parse(searchTB.Text))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }

                if (fNameFilterRB.Checked)
                {
                    if (((Student)row.DataBoundItem).FName.ToLower().Contains(searchTB.Text.ToLower()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }

                if (lNameFilterRB.Checked)
                {
                    if (((Student)row.DataBoundItem).LName.ToLower().Contains(searchTB.Text.ToLower()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }

                if (phoneNumFilterRB.Checked)
                {
                    if (((Student)row.DataBoundItem).PhoneNum.Contains(searchTB.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                cM.ResumeBinding();
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            DBSystem.Students.Remove((Student)studentTableDGV.SelectedRows[0].DataBoundItem);
            studentTableDGV.Rows[0].Selected = true;
            rowIdx = studentTableDGV.SelectedRows[0].Index;
            Student currentStudent = (Student)studentTableDGV.Rows[rowIdx].DataBoundItem;
            displayFile(currentStudent);
            refreshView();
            DBSystem.updateCSVFile();
        }
    }
}
