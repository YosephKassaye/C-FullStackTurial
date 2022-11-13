using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.  Accept a number and check if the number is even or odd
            //2.  Accept twombers and found the sum, product, difference and remainder
            //3.  Accept Student (StudentId, FName, LName, Gender)

            // How many variables do I need?
            // What dataype (int, string, DateTime, bool, class )

            //1. number, result
            //datatype int , string 
            //int number= int.Parse(Console.ReadLine());
            //string result;
            //if (number / 2 == 0)
            //    result = "even";
            //else
            //    result = "odd";

            //Console.WriteLine("The number is " + result);
            //Console.ReadLine();
            //2. number1, number2, result 
            //    int      int   int
            //int no1, no2, result;
            //string s;  //+, -, *, /
            //Console.WriteLine("Enter the firstNumber");
            //no1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number");
            //no2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Sign");
            //s = Console.ReadLine();
            //Console.WriteLine("The result is" + FindResult(no1, no2, s));

            //Console.ReadLine();

            //Student s = new Student
            //{
            //    StudentId = 1212,
            //    FName = "Yoseph",
            //    LName = "Kassaye",
            //    Gender = "M" 
            //};
            //Console.WriteLine("Yor First Name is " + s.FName + 
            //        " Your Last Name is " + s.LName  + " Your Gender is " + s.Gender);

            //Console.ReadLine();

            ICalculator c = new KCalc();
            c.GetType();
            c.addTwoNumbers(12, 12);
            c.MultTwoNumbers(12, 12);

            c = new  CalcinaCar();
            c.GetType();
        }

        //public static int FindResult(int n1, int n2, string si)
        //{
        //    if (si == "+")
        //        return n1 + n2;
        //    else if (si == "-")
        //        return n1 - n2;
        //    else if (si == "*")
        //        return n1 * n2;
        //    else if (si == "/")
        //        return n1 % n2;
        //    else return 0;

        //}
    }
}
