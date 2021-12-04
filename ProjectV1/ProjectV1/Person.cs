using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    class Person
    {
        protected String _fName;
        protected String _lName;
        protected String _phoneNum;
        protected String _Address;
        protected String _postalCode;

        public Person()
        {
        }

        public Person(string fName, string lName, string phoneNum)
        {
            _fName = fName;
            _lName = lName;
            _phoneNum = phoneNum;
        }

        public Person(string fName, string lName, string phoneNum, string address, string postalCode)
        {
            _fName = fName;
            _lName = lName;
            _phoneNum = phoneNum;
            _Address = address;
            _postalCode = postalCode;
        }
    }
}
