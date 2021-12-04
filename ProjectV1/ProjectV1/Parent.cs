using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    [Serializable]
    class Parent : Person
    {
        public Parent()
        {
        }

        public Parent(string fName, string lName) : base(fName, lName)
        {
        }
    }
}
