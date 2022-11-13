using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempClass
{
    public  class KCalc: ICalculator
    {
        public string GetName()
        {
            return "Kitchen";
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
