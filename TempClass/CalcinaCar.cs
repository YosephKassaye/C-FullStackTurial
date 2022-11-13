using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempClass
{
    internal class CalcinaCar : ICalculator
    {
        public string GetName()
        {
            return "Car";
        }
        public int addTwoNumbers(int n1, int n2)
        {
            return n1 + n2;
        }

        public int DivideTwonumbers(int n1, int n2)
        {
            return n1 / n2;
        }

        public int GetRemainder(int n1, int n2)
        {
            return n1 % n2;
        }

        public int MultTwoNumbers(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Subtractanmber(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
