using Compare_People;

List<Person> people = new List<Person>();

people.Add(new Person("Ivan", 170));
people.Add(new Person("Sonya", 150));
people.Add(new Person("Maria", 150));
people.Add(new Person("Georgi", 180));

people.Sort();

foreach (Person person in people)
{
    Console.WriteLine(person);
}
