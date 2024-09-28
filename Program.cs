
using LibraryIteration;

Library library = new Library();
library.Add(new Book("Prikazka za stulbata", 1900, " Hristo Smirnenski"));
library.Add(new Book("Knigata na shefa", 2024, "Author 3", "Author 4"));
library.Add(new Book("How to cook with Author 5 and 6", 2024, "Author 5", "Author 6"));
library.Add(new Book("The biography of the King - Pele", 2024, "Author 7", "Author 8"));

foreach (Book book in library)
{
    Console.WriteLine(book);
}

