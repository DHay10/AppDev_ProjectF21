﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectV1
{
    public partial class NewStudentView : Form
    {
        string filepath = "studentCSV.txt";

        public NewStudentView()
        {
            InitializeComponent();
        }

        public void addInfo(string fName, string lName, string dob, string cell, string address, string postal, 
            string emergCell, string fatherName, string motherName)
        {
            try
            {
                DateTime dobConvert = DateTime.Parse(dob);
                Student student = new Student(fName, lName, dobConvert, cell, address, postal, emergCell, fatherName, motherName);
                DBSystem.Students.Add(student);
                string[] splitDOB = dob.Split(',');
                string year = splitDOB[0];
                string month = " " + splitDOB[1];
                string day = " " + splitDOB[2];
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@filepath, true))
                {
                    streamWriter.WriteLine(student.StudentID + "," + fName + "," + lName + ","  + year+month+day + "," 
                        +cell + "," + address + "," + postal + "," + emergCell + "," + fatherName + "," + motherName);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something went wrong :", ex);
            }
        }


        private void newStudentSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                addInfo(studentFirstNameTb.Text, studentLastNameTb.Text, dobTb.Text, studentCellTb.Text,
                 addressTb.Text, postalCodeTb.Text, parentCellTb.Text, fatherFirstNameTb.Text, motherFirstNameTb.Text);

                if (studentFirstNameTb.Text == null || studentLastNameTb.Text == null || dobTb.Text == null ||
                studentCellTb.Text == null || addressTb.Text == null || postalCodeTb.Text == null || parentCellTb.Text == null ||
                fatherFirstNameTb.Text == null || motherFirstNameTb.Text == null)
                {
                    throw new Exception();
                }
                MessageBox.Show($"{studentFirstNameTb.Text} was added to the system", "Complete", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                studentFirstNameTb.Clear();
                studentLastNameTb.Clear();
                studentCellTb.Clear();
                fatherFirstNameTb.Clear();
                motherFirstNameTb.Clear();
                dobTb.Clear();
                parentCellTb.Clear();
                addressTb.Clear();
                postalCodeTb.Clear();
            }
            catch (Exception exs)
            {
                MessageBox.Show("All boxes must be filled out. Make sure you entered all of the student's info \n"+ exs,
                    "Not everything is filled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            previewLabel.Text = "Preview of Student:";
            fNameLabel.Text = "First Name:";
            lNameLabel.Text = "Last Name:";
            cellLabel.Text = "Cellphone:";
            dobLabel.Text = "Date of Birth:";
            fatherNameLabel.Text = "Father Name:";
            motherNameLabel.Text = "Mother Name:";
            emergLabel.Text = "Emergency Cell:";
            addyLabel.Text = "Address:";
            postalLabel.Text = "Postal Code:";

            previewfName.Text = studentFirstNameTb.Text;
            previewlName.Text = studentLastNameTb.Text;
            previewCell.Text = studentCellTb.Text;
            previewDob.Text = dobTb.Text;
            previewFatherName.Text = fatherFirstNameTb.Text;
            previewMotherName.Text = motherFirstNameTb.Text;
            previewEmerg.Text = parentCellTb.Text;
            previewAddy.Text = addressTb.Text;
            previewPostal.Text = postalCodeTb.Text;

        }
    }
}
