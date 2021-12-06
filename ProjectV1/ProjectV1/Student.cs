using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    /**
      * Student Class
      */
    class Student
    {
        private int _studentID;
        private string _fName;
        private string _lName;
        private DateTime _dob;
        private string _phoneNum;
        private string _address;
        private string _postalCode;
        private string _emergencyNum;
        private string _guardian1Name;
        private string _guardian2Name;

        // Default Constructor
        public Student()
        {
        }

        /** 
          * Constructor with all param except studentID
          * The _studentID will be initialized using checkAvailableID()
          */
        public Student(string fName, string lName, DateTime dob, string phoneNum, string address, string postalCode, 
            string emergencyNum, string guardian1Name, string guardian2Name)
        {
            StudentID = checkAvailableID();
            FName = fName;
            LName = lName;
            Dob = dob;
            PhoneNum = phoneNum;
            Address = address;
            PostalCode = postalCode;
            EmergencyNum = emergencyNum;
            Guardian1Name = guardian1Name;
            Guardian2Name = guardian2Name;
        }

        /**
          * Constructor with all param
          */
        public Student(int studentID, string fName, string lName, DateTime dob, string phoneNum, string address, 
            string postalCode, string emergencyNum, string guardian1Name, string guardian2Name)
        {
            StudentID = studentID;
            FName = fName;
            LName = lName;
            Dob = dob;
            PhoneNum = phoneNum;
            Address = address;
            PostalCode = postalCode;
            EmergencyNum = emergencyNum;
            Guardian1Name = guardian1Name;
            Guardian2Name = guardian2Name;
        }

        /**
          * Method to check which ID is currently unnassigned in ascending order
          */
        private static int checkAvailableID()
        {
            int id = 1;     // Starting ID
            for (int i = 0; i < DBSystem.Students.Count; i++) { // Loops through because list is not sorted by ID
                foreach (Student s in DBSystem.Students)
                {
                    if (id == s.StudentID)      // If studentID is already used add to the id index
                    {
                        ++id;
                    }
                }
            }
            return id;
        }

        // Properties
        public int StudentID
        {
            get => _studentID;
            set => _studentID = value;
        }

        public string FName
        {
            get => _fName;
            set => _fName = value;
        }

        public string LName
        {
            get => _lName;
            set => _lName = value;
        }

        public DateTime Dob
        {
            get => _dob;
            set => _dob = value;
        }

        public string PhoneNum
        {
            get => _phoneNum;
            set => _phoneNum = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }
        public string PostalCode
        {
            get => _postalCode;
            set => _postalCode = value;
        }

        public string EmergencyNum
        {
            get => _emergencyNum;
            set => _emergencyNum = value;
        }

        public string Guardian1Name
        {
            get => _guardian1Name;
            set => _guardian1Name = value;
        }

        public string Guardian2Name
        {
            get => _guardian2Name;
            set => _guardian2Name = value;
        }
    }
}
