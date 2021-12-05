using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    class DatabaseSystem
    {
        protected static List<Student> students;
        public static void initData()
        {
            string[] lines = System.IO.File.ReadAllLines(@"student.csv");
            foreach(string line in lines)
            {
                string[] columns = line.Split(',');
                students.Add(new Student(columns[1], columns[2], DateTime.Parse(columns[3]), columns[4], columns[5], columns[6], columns[7], columns[8], columns[9]));
            }
        }
    }

}
