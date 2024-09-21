using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Student : Person
    {
		private string school;

		public string School
		{
			get { return school; }
			set { school = value; }
		}

        public Student(string name, int age, string school) : base(name, age)
        {
            School = school;
        }

        public override string ToString()
        {
            return $"{Name} {Age}, school: {School} "; //втори начин за писане на ToString() метода
        }
    }
}
