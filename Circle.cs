using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return Math.PI * Size * Size;
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}
