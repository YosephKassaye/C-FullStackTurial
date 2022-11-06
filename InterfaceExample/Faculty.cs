using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Faculty : IStudent
    {
        public string Attendance()
        {
            return "Faculty level attendance is done";
        }

        public string CourseAssign()
        {
            return "Faculty level Course assignment is done";

        }

        public string Grade()
        {
            return "Faculty level Grade is done";
        }

        public string Graduate()
        {
            return "Faculty level Grad is done";
        }

        public string Register()
        {
            return "Faculty level Registration is done";
        }
    }
}
