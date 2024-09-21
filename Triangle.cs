using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return (Size * Size * Math.Sqrt(3)) / 4;
        }

        public override string GetName()
        {
            return "Equilateral triangle";
        }
    }
}
