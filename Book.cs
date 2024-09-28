using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIteration
{
    public class Book
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> Authors { get; set; }

        public Book(string title,int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);

            
        }

        public override string ToString()
        {
            return $"{Title} ({Year}) - {string.Join(" ", Authors)}";
        }


    }
}
