using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Department : IStudent
    {
        public string Attendance()
        {
            return "Department level attendance is done";
        }

        public string CourseAssign()
        {
            return "Department level Course assignment is done";

        }

        public string Grade()
        {
            return "Department level Grade is done";
        }

        public string Graduate()
        {
            return "Department level Grad is done";
        }

        public string Register()
        {
            return "Department level Registration is done";
        }
    }
}
