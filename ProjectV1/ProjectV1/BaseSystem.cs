using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1
{
    class BaseSystem
    {
        protected static List<Student> students;
        protected static List<Parent> parents;

        public static void initData()
        {
            using(var reader = new StreamReader(@"students.csv"))
            {

            }
        }
    }
}
