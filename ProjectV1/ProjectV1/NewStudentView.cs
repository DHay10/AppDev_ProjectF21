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
        int studentId;
        string filepath = "studentCSV.txt";
        private StreamReader fileReader;
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
            string[] values;
            /*var inputRecord = fileReader.ReadLine();
            string[] inputFields = inputRecord.Split(',');
            int n = inputFields.Length - 10;
            if (inputRecord == null)
            {
                studentId = 0;
            }
            else
            {
                inputFields[n] = studentId.ToString();
                studentId++;
            }*/
            /*using (var reader = new StreamReader(@filepath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    values = line.Split(',');
                }
                if (reader == null)
                {
                    studentId = 0;
                }
                else
                {
                     values[values.Length-10];
                }
            }*/

            addInfo(studentId, studentFirstNameTb.Text, studentLastNameTb.Text, studentCellTb.Text,
                fatherFirstNameTb.Text, fatherLastNameTb.Text, motherFirstNameTb.Text, motherLastNameTb.Text,
                parentCellTb.Text, addressTb.Text, postalCodeTb.Text);
            studentId++;
            MessageBox.Show($"{studentFirstNameTb.Text} was added to the system","Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            studentFirstNameTb.Clear();
            studentLastNameTb.Clear();
            studentCellTb.Clear();
            fatherFirstNameTb.Clear();
            fatherLastNameTb.Clear();
            motherFirstNameTb.Clear();
            motherLastNameTb.Clear();
            parentCellTb.Clear();
            addressTb.Clear();
            postalCodeTb.Clear();
        }

    }
}
