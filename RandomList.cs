using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomElements
{
    public class RandomList<T> : List<T>
    {
        public RandomList(List<T> list) 
        {
            base.AddRange(list);
        }
        public T RandomElement()
        {
            Random random = new Random();
            int index = random.Next(0, Count);
            return base[index];

        }
    }
}
