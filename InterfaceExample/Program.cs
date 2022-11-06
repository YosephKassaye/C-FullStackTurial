using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Faculty f = new Faculty();
            Console.WriteLine(f.Grade());
        }
    }
}
