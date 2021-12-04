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
        private Parent _parent1;
        private Parent _parent2;

        public static int nextID = 1;

        public Student()
        {
        }

        public Student(Parent parent1, Parent parent2, string fName, string lName, string phoneNum, string address, string postalCode, string emergencyNum) : 
            base(fName, lName, phoneNum, address, postalCode, emergencyNum)
        {
            _studentID = ++nextID;
            _parent1 = parent1;
            _parent2 = parent2;
        }
    }
}
