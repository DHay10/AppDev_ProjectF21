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
using System.Data.SqlClient;

namespace ProjectV1
{
    public partial class NewStudentView : Form
    {
        int studentId;
        string filepath = "student.csv";
        string[] fields;
        public NewStudentView()
        {
            InitializeComponent();
        }

        public void addInfo(int id, string fName, string lName, string cell, string fatherFName, string fatherLName,
            string motherFName, string motherLName, string parentCell, string address, string postal)
        {

            try
            {
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@filepath, true))
                {
                    streamWriter.WriteLine(id + "," + fName + "," + lName + "," + cell + "," + fatherFName
                        + "," + fatherLName + "," + motherFName + "," + motherLName + "," + parentCell + "," + address
                        + "," + postal);
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
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                if (lines == null)
                {
                    studentId = 0;
                }
                else
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        fields = lines[i].Split(',');
                    }
                    string stringStudentId = fields[fields.Length - 11];
                    //studentId = int.Parse(stringStudentId);
                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@filepath, true))
                    {
                        streamWriter.WriteLine(stringStudentId);
                    }
                }
            }
            catch (Exception exs)
            {
                throw new ApplicationException("Something went wrong :", exs);
            }


            addInfo(studentId, studentFirstNameTb.Text, studentLastNameTb.Text, studentCellTb.Text,
                fatherNameTB.Text, motherNameTB.Text, motherFirstNameTb.Text, motherLastNameTb.Text,
                emergencyNumberTB.Text, addressTb.Text, postalCodeTb.Text);
            MessageBox.Show("The Student was added to the system", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            studentFNameTB.Clear();
            studentLNameTB.Clear();
            dobTB.Clear();
            addressTB.Clear();
            postalCodeTb.Clear();
            cityTB.Clear();
            countryTB.Clear();
            phoneNumTB.Clear();
            fatherNameTB.Clear();
            motherNameTB.Clear();
            emergencyNumberTB.Clear();
        }

    }
}
