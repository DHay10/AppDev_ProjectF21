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
        BindingSource bs = new BindingSource();     // Binding Source to set up data source for DataGridView
        public DatabaseView()
        {
            InitializeComponent();
        }

        private void DatabaseView_Load(object sender, EventArgs e)
        {
            bs.DataSource = typeof(Student);            // Creates table following the data members of Student Class
            studentTableDGV.DataSource = bs;            // Making the data source of DGV to BindingSource

            // Adding all the students from base list to the BindingSource
            foreach (Student s in DBSystem.Students)    
            {
                bs.Add(s);
            }

            // Linking bindingSource to DGV as data source
            studentTableDGV.DataSource = bs;

            // Columns Editing
            studentTableDGV.AutoGenerateColumns = true;
            studentTableDGV.Columns["StudentID"].HeaderText = "Student ID";
            studentTableDGV.Columns["FName"].HeaderText = "First Name";
            studentTableDGV.Columns["LName"].HeaderText = "Last Name";
            studentTableDGV.Columns["PhoneNum"].HeaderText = "Phone Number";
            studentTableDGV.Columns["Dob"].Visible = false;
            studentTableDGV.Columns["Address"].Visible = false;
            studentTableDGV.Columns["PostalCode"].Visible = false;
            studentTableDGV.Columns["EmergencyNum"].Visible = false;
            studentTableDGV.Columns["Guardian1Name"].Visible = false;
            studentTableDGV.Columns["Guardian2Name"].Visible = false;

            // Sorting DGB by Student ID (Unfinished)
            DataGridViewColumn columnToSort = studentTableDGV.Columns["StudentID"];

            // Select the First Row on load and display the file of the Student linked to that row
            studentTableDGV.Rows[0].Selected = true;
            rowIdx = studentTableDGV.SelectedRows[0].Index;
            Student currentStudent = (Student)studentTableDGV.Rows[rowIdx].DataBoundItem;
            displayFile(currentStudent);
        }

        // Refresh Button Click Event
        private void refreshB_Click(object sender, EventArgs e)
        {
            refreshView();
        }

        /**
          * Method to reload the database and DGV (Selecting first row)
          */ 
        private void refreshView()
        {
            bs.Clear();     // Empties curent value/rows
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

        int rowIdx; // Initialize the row index var

        /**
          *  Event when double click cellcontent, displays file of the Student bound to the row of that cell
          */ 
        private void studentTableDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student currentStudent = (Student) studentTableDGV.SelectedRows[0].DataBoundItem;
            displayFile(currentStudent);
        }

        /**
          *  Event when click row header, displays file of the Student bound to the row
          */
        private void studentTableDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Student currentStudent = (Student)studentTableDGV.CurrentRow.DataBoundItem;
            displayFile(currentStudent);
        }

        /**
          *  Event when previous button clicked, selects and displays file of the Student bound to the previous row of the current one
          *  It loops back to the last row if the current row is the first one
          */
        private void prevB_Click(object sender, EventArgs e)
        {
            rowIdx = studentTableDGV.SelectedRows[0].Index;
            if (rowIdx > 0) {       // Check if the rowIdx is bigger than 0
                studentTableDGV.Rows[--rowIdx].Selected = true;
                Student currentStudent = (Student) studentTableDGV.SelectedRows[0].DataBoundItem;
                displayFile(currentStudent);
            }
            else
            {
                rowIdx = studentTableDGV.RowCount - 1;      // Set the rowIdx to the last one
                studentTableDGV.Rows[rowIdx].Selected = true;
                Student currentStudent = (Student) studentTableDGV.SelectedRows[0].DataBoundItem;
                displayFile(currentStudent);
            }
        }

        /**
          *  Event when next button clicked, selects and displays file of the Student bound to the next row of the current one
          *  It loops back to the first row if the current row is the last one
          */
        private void nextB_Click(object sender, EventArgs e)
        {
            rowIdx = studentTableDGV.SelectedRows[0].Index;
            if (rowIdx < studentTableDGV.RowCount - 1)  // Check if the rowIdx is smaller than number of rows
            {
                studentTableDGV.Rows[++rowIdx].Selected = true;
                Student currentStudent = (Student) studentTableDGV.SelectedRows[0].DataBoundItem;
                displayFile(currentStudent);
            }
            else
            {
                rowIdx = 0;                             // Set the rowIdx to the first one
                studentTableDGV.Rows[rowIdx].Selected = true;
                Student currentStudent = (Student) studentTableDGV.SelectedRows[0].DataBoundItem;
                displayFile(currentStudent);
            }
        }

        /**
          * Method to show all current info of the Student in the appropriate TB in the form 
          */
        private void displayFile(Student currentStudent)
        {
            idTB.Text = string.Format("{0:D8}", currentStudent.StudentID);      // Zero padding by 8
            fNameTB.Text = currentStudent.FName;
            lNameTB.Text = currentStudent.LName;
            dobTB.Text = currentStudent.Dob.ToString("d");                      // Short date format
            phoneNumTB.Text = currentStudent.PhoneNum;
            addressTB.Text = currentStudent.Address;
            postalCodeTB.Text = currentStudent.PostalCode;
            emergencyNumTB.Text = currentStudent.EmergencyNum;
            fGuardianNameTB.Text = currentStudent.Guardian1Name;
            sGuardianNameTB.Text = currentStudent.Guardian2Name;
        }

        /**
          * Method to update the info of the selected Student using the new values inside the text boxes.
          * It will also update the CSV file and refresh the DGV
          */
        private void updateB_Click(object sender, EventArgs e)
        {
            Student currentStudent = (Student)studentTableDGV.SelectedRows[0].DataBoundItem;
            currentStudent.PhoneNum = phoneNumTB.Text;
            currentStudent.Address = addressTB.Text;
            currentStudent.PostalCode = postalCodeTB.Text;
            currentStudent.EmergencyNum = emergencyNumTB.Text;
            currentStudent.Guardian1Name = fGuardianNameTB.Text;
            currentStudent.Guardian2Name = sGuardianNameTB.Text;
            DBSystem.updateCSVFile();
            studentTableDGV.Refresh();
        }

        /**
          * Event when the text in the 'search' Text Box is changed, filtering through the database to show
          * Student containing the value inside the text box depending on the selected radio button.
          * Search Function is not cap sensitive
          */ 
        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            CurrencyManager cM = (CurrencyManager)BindingContext[studentTableDGV.DataSource];       // Currency Manager for the binding Source to control binding process
            cM.SuspendBinding();        // Stopping the Binding to let the rows be modified
            if (searchTB.Text == "")    // If searchTB is empty, load all the students
            {
                foreach (DataGridViewRow row in studentTableDGV.Rows)
                {
                    row.Visible = true;
                }
                return;
            }
            // Loops through each row of the DGV
            foreach (DataGridViewRow row in studentTableDGV.Rows)
            {
                if (studentIDFilterRB.Checked)
                {
                    int a;      // Return int of TryParse
                    if (!Int32.TryParse(searchTB.Text, out a))      // Check if the textbox is digit only
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
                cM.ResumeBinding();     // Resume Binding
            }
        }

        /**
          * Event when 'delete' button is clicked, deletes the selected student from the database
          */
        private void deleteB_Click(object sender, EventArgs e)
        {
            DBSystem.Students.Remove((Student)studentTableDGV.SelectedRows[0].DataBoundItem);
            // Sets the selected row to the first one and displays
            studentTableDGV.Rows[0].Selected = true;
            rowIdx = studentTableDGV.SelectedRows[0].Index;
            Student currentStudent = (Student)studentTableDGV.Rows[rowIdx].DataBoundItem;
            displayFile(currentStudent);
            // Refresh and update the CSV file
            refreshView();
            DBSystem.updateCSVFile();
        }
    }
}
