using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
		private string color;

		public string Color
		{
			get { return color; }
			private set { color = value; }
		}

		private double size;	

		public double Size
		{
			get { return size; }
			private set { size = value; }
		}

        public Shape(string color, double size)
        {
            Color = color;
			Size = size;
        }

        public override string ToString()
        {
            return $"Color: {Color}, Size: {Size}";
        }

		public abstract string GetName();

		public abstract double GetArea();

    }
}
