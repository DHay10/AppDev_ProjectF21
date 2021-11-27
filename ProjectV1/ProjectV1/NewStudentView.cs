using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectV1
{
    public partial class NewStudentView : Form
    {
        int studentId = 0;
        string filepath = "studentCSV.txt";
        public NewStudentView()
        {
            InitializeComponent();
        }

        public void addInfo(int id,string fName,string lName,string cell, string fatherFName, string fatherLName,
            string motherFName, string motherLName,string parentCell,string address,string postal)
        {
            try
            {
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@filepath, true))
                {
                    streamWriter.WriteLine(id + "," + fName + "," + lName + "," + cell + "," + fatherFName
                        + "," + fatherLName + "," + motherFName + "," + motherLName + "," + parentCell + "," + address
                        + "," + postal);
                }
            }catch(Exception ex)
            {
                throw new ApplicationException("Something went wrong :", ex);
            }
        }

        private void newStudentSaveButton_Click(object sender, EventArgs e)
        {
            addInfo(studentId, studentFirstNameTb.Text, studentLastNameTb.Text, studentCellTb.Text,
                fatherFirstNameTb.Text, fatherLastNameTb.Text, motherFirstNameTb.Text, motherLastNameTb.Text,
                parentCellTb.Text, addressTb.Text, postalCodeTb.Text);
            studentId++;
            MessageBox.Show($"{studentFirstNameTb.Text} was added to the system","complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
