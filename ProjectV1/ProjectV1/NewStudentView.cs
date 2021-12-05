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
using System.Text.RegularExpressions;

namespace ProjectV1
{
    public partial class NewStudentView : Form
    {
        string filepath = "studentCSV.txt"; //filepath to the csv file
        public NewStudentView()
        {
            InitializeComponent();
        }

        // method to add all the info into the csv file
        public void addInfo(string fName, string lName, string dob, string cell, string address, string postal, 
            string emergCell, string fatherName, string motherName)
        {
            try
            {
                //converting the date of birth from string to DateTime
                DateTime dobConvert = DateTime.Parse(dob);
                //passing the parameters and making a new student with it
                Student student = new Student(fName, lName, dobConvert, cell, address, postal, emergCell, fatherName, motherName);
                //adding the new student to the databse
                DBSystem.Students.Add(student);
                //using streamWriter to write to the csv file all the parameters
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@filepath, true))
                {
                    streamWriter.WriteLine(student.StudentID + "," + fName + "," + lName + ","  + dob + "," 
                        +cell + "," + address + "," + postal + "," + emergCell + "," + fatherName + "," + motherName);
                }
            }
            //if something goes wrong it gets caught here
            catch (Exception ex)
            {
                throw new ApplicationException("Something went wrong :", ex);
            }
        }

        //save button method
        private void newStudentSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if first name,last name AND phone number are the same,throw excpetion
                foreach (Student s in DBSystem.Students)
                {
                    if (studentFirstNameTb.Text == s.FName || studentLastNameTb.Text == s.LName || 
                        studentCellTb.Text == s.PhoneNum)
                    {
                        throw new ArgumentException();
                    }
                }
                //if phone numbers are not added in correctly, throw exception
                Regex regEx = new Regex(@"^\([0-9]{3}\)[0-9]{3}\-[0-9]{4}$");

                if (regEx.IsMatch(studentCellTb.Text) == false || regEx.IsMatch(parentCellTb.Text) == false)
                {
                    throw new InvalidOperationException();
                }

                //if anything is null, throw exception
                if (studentFirstNameTb.Text == null || studentLastNameTb.Text == null || dobTb.Text == null ||
                studentCellTb.Text == null || addressTb.Text == null || postalCodeTb.Text == null || parentCellTb.Text == null ||
                fatherFirstNameTb.Text == null || motherFirstNameTb.Text == null)
                {
                    throw new ArgumentNullException();
                }

                //using add info method
                addInfo(studentFirstNameTb.Text, studentLastNameTb.Text, dobTb.Text, studentCellTb.Text,
                 addressTb.Text, postalCodeTb.Text, parentCellTb.Text, fatherFirstNameTb.Text, motherFirstNameTb.Text);

                MessageBox.Show($"{studentFirstNameTb.Text} was added to the system", "Complete", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //clear all boxes so user can enter another student if desired
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
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("All boxes must be filled out. Make sure you entered all of the student's info \n"+ ex,
                    "Not everything is filled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show("Must enter a valid phone number. Format for phone is (XXX)XXX-XXXX \n" + ex,
                    "Must enter proper phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("This student already exists \n" + ex,
                    "Student already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //preview button method
        private void previewButton_Click(object sender, EventArgs e)
        {
            //labels that say what the info is
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

            //labs that display the info from the user
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
