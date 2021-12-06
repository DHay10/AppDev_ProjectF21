using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    /**
      * DBSystem Class
      * Acts as the database for the project
      */
    class DBSystem
    {
        // This list acts as a local database for the whole system
        protected static List<Student> _students;

        /** 
          * This method is to initialize the _students list (database) using 
          * the studentCSV.txt file located in this project.
          */
        public static void initData()
        {
            _students = new List<Student>();
            string[] lines = System.IO.File.ReadAllLines(@"studentCSV.txt");
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                _students.Add(new Student(Int32.Parse(columns[0]), columns[1], columns[2], DateTime.Parse(columns[3]), columns[4], columns[5], columns[6], columns[7], columns[8], columns[9]));
            }
        }
        
        /** 
          * This method is used to update the studentCSV.txt file 
          * located in this project with the current list of Students.
          */
        public static void updateCSVFile()
        {
            System.IO.File.WriteAllText(@"studentCSV.txt", string.Empty);
            using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@"studentCSV.txt", true))
            {
                foreach (Student s in _students)
                {
                    streamWriter.WriteLine(s.StudentID + "," + s.FName + "," + s.LName + "," + s.Dob.ToString("d") + ","
                            + s.PhoneNum + "," + s.Address + "," + s.PostalCode + "," + s.EmergencyNum + "," + s.Guardian1Name + "," + s.Guardian2Name);
                }
            }
        }

        /**
          * Getter for the list<Student> _students
          */
        public static List<Student> Students => _students;
    }
}
