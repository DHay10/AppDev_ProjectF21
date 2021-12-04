using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    class Student : Person
    {
        private int _studentID;
        private Person _father;
        private Person _mother;

        public static int nextID = 1;

        public Student()
        {
        }

        public Student(Person father, Person mother, string fName, string lName, string phoneNum, string address, string postalCode) : 
            base(fName, lName, phoneNum, address, postalCode)
        {
            _studentID = ++nextID;
            _father = father;
            _mother = mother;
        }
    }
}
