using OOPStatistics;

int peopleCount = int.Parse(Console.ReadLine());

List<Person> people = new List<Person>();

for (int i = 0; i < peopleCount; i++)
{
    string[] data = Console.ReadLine().Split();

    people.Add(new Person(name: data[0], age: int.Parse(data[1])));
}

people = people.Where(person => person.Age > 30).OrderBy(person => person.Name).ToList();

Console.WriteLine(string.Join("\n", people));