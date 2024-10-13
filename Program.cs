try
{

    using (StreamReader reader = new StreamReader("file.txt"))
    {
        string line = reader.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = reader.ReadLine();
        }
    }
    
}
catch(FileNotFoundException)
{
    Console.WriteLine("The file does not exist.");
}
