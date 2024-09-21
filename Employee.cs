using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Employee : Person
    {
		private string company;

		public string Company
		{
			get { return company; }
			set { company = value; }
		}

        public Employee(string name, int age, string company) : base(name, age) 
        {
            Company = company;
        }

        public override string ToString()
        {
            return base.ToString() + $", company: {Company}";
        }
    }
}
