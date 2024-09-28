using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_People
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Height { get; set; }

        public Person(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public override string ToString()
        {
            return $"{Name} ({Height} cm)";
        }

        public int CompareTo(Person? other)
        {
            int difference = this.Height.CompareTo(other.Height);   

            if (difference != 0)
            {
                return difference;
            }

            return this.Name.CompareTo(other.Name);
        }
    }
}
