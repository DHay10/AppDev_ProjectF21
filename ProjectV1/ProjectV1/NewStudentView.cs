using System;
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
                    streamWriter.WriteLine(student.getStudentId()+ "," + fName + "," + lName + ","  + year+month+day + "," 
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
