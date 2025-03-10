using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFamily
{
    public class Family
    {
        private List<Person> people = new List<Person>();

        public void Add(Person person)
        {
            people.Add(person);
        }
        public void Sort()
        {
            people = people.OrderBy(x => x.Name).ToList();
        }

        public override string ToString()
        {
            Sort();
            return string.Join("\n", people);
        }
    }
}
