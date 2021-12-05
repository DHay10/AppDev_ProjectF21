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

        public void addInfo(string fName, string lName, string cell, string dob, string fatherName, string motherName,
            string emergCell, string address, string postal)
        {
            try
            {
                DateTime dobConvert = DateTime.Parse(dobTb.Text);
                Student student = new Student(studentFirstNameTb.Text, studentLastNameTb.Text, dobConvert, studentCellTb.Text,
                    addressTb.Text, postalCodeTb.Text, parentCellTb.Text, fatherFirstNameTb.Text, motherFirstNameTb.Text);
                string[] splitDOB = dob.Split(',');
                string year = splitDOB[0];
                string month = " " + splitDOB[1];
                string day = " " + splitDOB[2];
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@filepath, true))
                {
                    streamWriter.WriteLine(student.getStudentId()+ "," + fName + "," + lName + "," + cell + ","  + year+month+day + "," +
                        fatherName + ","+ motherName + ","+ emergCell + "," + address + "," + postal);
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
                addInfo(studentFirstNameTb.Text, studentLastNameTb.Text, studentCellTb.Text, dobTb.Text,
                 fatherFirstNameTb.Text, motherFirstNameTb.Text, parentCellTb.Text, addressTb.Text, postalCodeTb.Text);
            }
            catch (Exception exs)
            {
                throw new ApplicationException("Something went wrong :", exs);
            }
            MessageBox.Show($"{studentFirstNameTb.Text} was added to the system","Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
