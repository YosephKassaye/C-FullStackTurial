using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempClass
{
    public  interface ICalculator
    {
       int  addTwoNumbers(int n1, int n2);
       int  Subtractanmber(int n1, int n2);
      int   MultTwoNumbers(int n1, int n2);
       int  DivideTwonumbers(int n1, int n2);
       int  GetRemainder(int n1, int n2);

    }
}
