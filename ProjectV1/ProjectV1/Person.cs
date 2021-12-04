using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    [Serializable]
    class Person
    {
        protected string _fName;
        protected string _lName;
        protected string _phoneNum;
        protected string _Address;
        protected string _postalCode;
        protected string _emergencyNum;

        public Person()
        {
        }

        public Person(string fName, string lName)
        {
            _fName = fName;
            _lName = lName;
        }

        public Person(string fName, string lName, string phoneNum, string address, string postalCode, string emergencyNum)
        {
            _fName = fName;
            _lName = lName;
            _phoneNum = phoneNum;
            _Address = address;
            _postalCode = postalCode;
            _emergencyNum = emergencyNum;
        }
    }
}
