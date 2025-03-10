using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottlesClass__OOP___basic_
{
    public class Bottle
    {
		private string type;

		public string Type
		{
			get { return type; }
			private set { type = value; }
		}

		private string content;

		public string Content
		{
			get { return content; }
			private set { content = value; }
		}

		private int capacity;

		public int Capacity
		{
			get { return capacity; }
			private set { capacity = value; }
		}

		private int size;

		public int Size
		{
			get { return size; }
			private set { 
					if (value > capacity)
					{
						throw new InvalidOperationException("The bottle overflows!");
					}
					if (value < 0)
					{
						throw new InvalidOperationException("Not enough content!");
					}
					size = value;
				}
				
		}

		public void Drink(int amount)
		{
			Size -= amount;

            Console.WriteLine($"Drinking {amount} ml of {Content}");
        }

		public void Fill(int amount)
		{
			Size += amount;

            Console.WriteLine($"Filled {amount} ml of {Content}");
        }

        public Bottle(string type, string content, int capacity, int size)
        {
            Type = type;
			Content = content;
			Capacity = capacity;
			Size = size;
        }

        public override string ToString()
        {
            return $"{Type} bottle with {Content}, capacity: {Capacity} ml filled with {Size} ml";
        }


    }
}
