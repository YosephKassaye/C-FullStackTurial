using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public  class Circle:Shape
    {
        
        public override string Draw()
        {
            Name = "Circle";
            return Name;

        }
    }
}
