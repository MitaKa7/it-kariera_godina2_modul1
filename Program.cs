using OOPFamily;

int peopleCount = int.Parse(Console.ReadLine());
Family family = new Family();

for (int i = 0; i < peopleCount; i++)
{
    string[] data = Console.ReadLine().Split();
    Person person = new Person(name: data[0], age: int.Parse(data[1]));
    family.Add(person);
}

Console.WriteLine(family);