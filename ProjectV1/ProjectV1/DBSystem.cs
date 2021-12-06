using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    class DBSystem
    {
        protected static List<Student> _students;
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

        public static void updateCSVFile()
        {
            System.IO.File.WriteAllText(@"studentCSV.txt", string.Empty);
            using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@"studentCSV.txt", true))
            {
                foreach (Student s in _students)
                {
                    streamWriter.WriteLine(s.StudentID + "," + s.FName + "," + s.LName + "," + s.Dob.ToString("d") + ","
                            + s.PhoneNum + "," + s.Address + "," + s.PostalCode + "," + s.EmergencyNum + "," + s.Parent1Name + "," + s.Parent2Name);
                }
            }
        }


        public static List<Student> Students => _students;
    }
}
