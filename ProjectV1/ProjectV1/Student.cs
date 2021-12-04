using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    [Serializable]
    class Student : Person
    {
        private int _studentID;
<<<<<<< HEAD
        private string _fName;
        private string _lName;
        private DateTime _dob;
        private int _phoneNum;
        private string _Address;
        private string _postalCode;
        private int _emergencyNum;
        private string _parent1Name;
        private string _parent2Name;
=======
        private Parent _parent1;
        private Parent _parent2;
>>>>>>> parent of cc89560 (Changed the newStudentView to add to database)

        public static int nextID = 1;

        public Student()
        {
        }

<<<<<<< HEAD
        public Student(string fName, string lName, DateTime dob, int phoneNum, string address, string postalCode, int emergencyNum, string parent1Name, string parent2Name)
=======
        public Student(Parent parent1, Parent parent2, string fName, string lName, string phoneNum, string address, string postalCode, string emergencyNum) : 
            base(fName, lName, phoneNum, address, postalCode, emergencyNum)
>>>>>>> parent of cc89560 (Changed the newStudentView to add to database)
        {
            _studentID = ++nextID;
            _parent1 = parent1;
            _parent2 = parent2;
        }
    }
}
