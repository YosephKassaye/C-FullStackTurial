using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public  interface IStudent
    {
        
         string Register();
        string CourseAssign();
        string Attendance();
        string Grade();
        string Graduate();
    }
}
