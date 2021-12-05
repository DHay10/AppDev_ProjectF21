using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    class Student
    {
        private int _studentID;
        private string _fName;
        private string _lName;
        private DateTime _dob;
        private string _phoneNum;
        private string _Address;
        private string _postalCode;
        private string _emergencyNum;
        private string _parent1Name;
        private string _parent2Name;

        public Student()
        {
        }

        public Student(string fName, string lName, DateTime dob, string phoneNum, string address, string postalCode, 
            string emergencyNum, string parent1Name, string parent2Name)
        {
            _studentID = DBSystem.Students.Count + 1;
            _fName = fName;
            _lName = lName;
            _dob = dob;
            _phoneNum = phoneNum;
            _Address = address;
            _postalCode = postalCode;
            _emergencyNum = emergencyNum;
            _parent1Name = parent1Name;
            _parent2Name = parent2Name;
        }

        public int getStudentId()
        {
            return _studentID;
        }
    }
}
