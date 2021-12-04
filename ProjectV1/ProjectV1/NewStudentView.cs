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
        //int studentId;
        //string filepath = "student.csv";
        //string[] fields;
        public NewStudentView()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public void addInfo(int id, string fName, string lName, string cell, string fatherFName, string fatherLName,
            string motherFName, string motherLName, string parentCell, string address, string postal)
        {

=======
        public void addInfo(int id,string fName,string lName,string cell, string fatherFName, string fatherLName,
            string motherFName, string motherLName,string parentCell,string address,string postal)
        {
            
>>>>>>> parent of cc89560 (Changed the newStudentView to add to database)
            try
            {
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@filepath, true))
                {
                    streamWriter.WriteLine(id + "," + fName + "," + lName + "," + cell + "," + fatherFName
                        + "," + fatherLName + "," + motherFName + "," + motherLName + "," + parentCell + "," + address
                        + "," + postal);
                }
<<<<<<< HEAD
            }
            catch (Exception ex)
=======
            }catch(Exception ex)
>>>>>>> parent of cc89560 (Changed the newStudentView to add to database)
            {
                throw new ApplicationException("Something went wrong :", ex);
            }
        }
=======
        //public void addInfo(int id,string fName,string lName,string cell, string fatherFName, string fatherLName,
        //    string motherFName, string motherLName,string parentCell,string address,string postal)
        //{
            
        //    try
        //    {
        //        using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@filepath, true))
        //        {
        //            streamWriter.WriteLine(id + "," + fName + "," + lName + "," + cell + "," + fatherFName
        //                + "," + fatherLName + "," + motherFName + "," + motherLName + "," + parentCell + "," + address
        //                + "," + postal);
        //        }
        //    }catch(Exception ex)
        //    {
        //        throw new ApplicationException("Something went wrong :", ex);
        //    }
        //}
>>>>>>> parent of dd70c78 (Deleted DBset and any connections)

        private void newStudentSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=.\\StudentDB.mdf;Integrated Security=True"))
                {
<<<<<<< HEAD
                    studentId = 0;
<<<<<<< HEAD
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
=======
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand("INSERT INTO tblStudents VALUES(@StudentFName, @StudentLName, @DateOfBirth," +
                        " @Address, @PostalCode, @City, @Country, @PhoneNum, @FatherName, @MotherName, @EmergencyPhone)", connection);
                    adapter.InsertCommand.Parameters.Add("@StudentFName", SqlDbType.NVarChar).Value = studentFNameTB.Text;
                    adapter.InsertCommand.Parameters.Add("@StudentLName", SqlDbType.NVarChar).Value = studentLNameTB.Text;
                    adapter.InsertCommand.Parameters.Add("@DateOfBirth", SqlDbType.NVarChar).Value = dobTB.Text;
                    adapter.InsertCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = addressTB.Text;
                    adapter.InsertCommand.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = postalCodeTb.Text;
                    adapter.InsertCommand.Parameters.Add("@City", SqlDbType.NVarChar).Value = cityTB.Text;
                    adapter.InsertCommand.Parameters.Add("@Country", SqlDbType.NVarChar).Value = countryTB.Text;
                    adapter.InsertCommand.Parameters.Add("@PhoneNum", SqlDbType.NVarChar).Value = phoneNumTB.Text;
                    adapter.InsertCommand.Parameters.Add("@FatherName", SqlDbType.NVarChar).Value = fatherNameTB.Text;
                    adapter.InsertCommand.Parameters.Add("@MotherName", SqlDbType.NVarChar).Value = motherNameTB.Text;
                    adapter.InsertCommand.Parameters.Add("@EmergencyPhone", SqlDbType.NVarChar).Value = emergencyNumberTB.Text;

                    connection.Open();
                    adapter.InsertCommand.ExecuteNonQuery();
                    connection.Close();
>>>>>>> parent of dd70c78 (Deleted DBset and any connections)
                }
            } catch(Exception exs)
            {
                throw new ApplicationException("Something went wrong :", exs);
            }
            //try
            //{
            //    string[] lines = System.IO.File.ReadAllLines(@filepath);
            //    if (lines == null)
            //    {
            //        studentId = 0;
            //    }
            //    else
            //    {
            //        for (int i = 0; i < lines.Length; i++)
            //        {
            //            fields = lines[i].Split(',');
            //        }
            //        string stringStudentId = fields[fields.Length - 11];
            //        //studentId = int.Parse(stringStudentId);
            //        using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@filepath, true))
            //        {
            //            streamWriter.WriteLine(stringStudentId);
            //        }
            //    }
            //}catch (Exception exs)
            //{
            //    throw new ApplicationException("Something went wrong :", exs);
            //}


            //addInfo(studentId, studentFirstNameTb.Text, studentLastNameTb.Text, studentCellTb.Text,
            //    fatherNameTB.Text, motherNameTB.Text, motherFirstNameTb.Text, motherLastNameTb.Text,
            //    emergencyNumberTB.Text, addressTb.Text, postalCodeTb.Text);
            MessageBox.Show("The Student was added to the system", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            studentFNameTB.Clear();
            studentLNameTB.Clear();
            dobTB.Clear();
            addressTB.Clear();
=======
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
            }catch (Exception exs)
            {
                throw new ApplicationException("Something went wrong :", exs);
            }
            
            
            addInfo(studentId, studentFirstNameTb.Text, studentLastNameTb.Text, studentCellTb.Text,
                fatherFirstNameTb.Text, fatherLastNameTb.Text, motherFirstNameTb.Text, motherLastNameTb.Text,
                parentCellTb.Text, addressTb.Text, postalCodeTb.Text);
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
>>>>>>> parent of cc89560 (Changed the newStudentView to add to database)
            postalCodeTb.Clear();
        }

    }
}
