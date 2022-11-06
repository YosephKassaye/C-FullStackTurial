using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        public string Name { get; set; }

        public virtual string Draw()
        {
            return "You are drawing" + Name;
        }

        public virtual string CalulateArea()
        {
            return "You are drawing" + Name;
        }
    }
}
