using SMSlibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ClassExample
{
 
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            Console.WriteLine( s.GetStudentInfo());
            Department d = new Department();
            Console.WriteLine("Department Info \n======================");
            Console.WriteLine(d.GetDepartmentInfo());

            Console.ReadLine();
        }
    }
}
