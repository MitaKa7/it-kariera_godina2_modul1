using AbstractOOP;


List<Animal> zoo = new List<Animal>();

Animal cat = new Cat();
Animal dog = new Dog();

zoo.Add(cat);
zoo.Add(dog);

foreach (Animal animal in zoo)
{
    animal.MakeSound();
    animal.Eat();
}
 
