using System;
using System.Collections.Generic;

class Animal
{
    public string Name { get; }
    public string Species { get; }
    public bool IsFed { get; set; }

    public Animal(string name, string species)
    {
        Name = name;
        Species = species;
        IsFed = false;
    }

    public void feed()
    {
        IsFed = true;
        Console.WriteLine($"{Species} {Name} has been given food.");
    }
}

class Enclosure
{
    public string Name { get; }
    public List<Animal> Animals { get; }

    public Enclosure(string name) {
        Name = name;
        Animals = new List<Animal>();
    }

    public void addAnimal(Animal animal) {
        Animals.Add(animal);
        Console.WriteLine($"{animal.Name} added to {Name} enclosure.");
    }
}

class ZooKeeper
{
    public string FirstName { get; }
    public string LastName { get; }
    public List<Animal> Animals { get; }

    public ZooKeeper(string firstName, string lastName) {
        FirstName = firstName;
        LastName = lastName;
        Animals = new List<Animal>();
    }

    public void assignAnimal(Animal animal) {
        Animals.Add(animal);
        Console.WriteLine($"{animal.Name} assigned to zookeeper: {FirstName} {LastName}.");
    }

    public void feedAnimals() {
        foreach (var animal in Animals)
        {
            animal.feed();
        }
    }
}

class Program
{
    static void Main()
    {
        Animal monkey = new Animal("Daniel", "Monkey");
        Animal bear = new Animal("Stanley", "Bear");

        Enclosure forest = new Enclosure("Birch Forest");
        forest.addAnimal(monkey);
        forest.addAnimal(bear);

        ZooKeeper keeperCharles = new ZooKeeper("Charles", "Leclerc");
        keeperCharles.assignAnimal(monkey);
        keeperCharles.assignAnimal(bear);

        keeperCharles.feedAnimals();
    }
}
