using System;

// Base class (Level 1)
public class Animal
{
    public string Name { get; set; }
    
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Animal constructor called for {name}");
    }
    
    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
}

// Intermediate class (Level 2) - inherits from Animal
public class Dog : Animal
{
    public string Breed { get; set; }
    
    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
        Console.WriteLine($"Dog constructor called for {name} of breed {breed}");
    }
    
    public override void Eat()
    {
        Console.WriteLine($"{Name} the {Breed} is eating dog food");
    }
    
    public virtual void Bark()
    {
        Console.WriteLine($"{Name} says: Woof! Woof!");
    }
}

// Derived class (Level 3) - inherits from Dog
public class Bulldog : Dog
{
    public string Color { get; set; }
    
    public Bulldog(string name, string color) : base(name, "Bulldog")
    {
        Color = color;
        Console.WriteLine($"Bulldog constructor called for {name} with color {color}");
    }
    
    public override void Bark()
    {
        Console.WriteLine($"{Name} the {Color} Bulldog says: Woof Woof Grrr!");
    }
    
    public void Play()
    {
        Console.WriteLine($"{Name} is playing and having fun");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Creating a Bulldog ---\n");
        
        // Multilevel inheritance in action
        Bulldog myDog = new Bulldog("Max", "Brown");
        
        Console.WriteLine("\n--- Calling methods ---\n");
        myDog.Eat();      // Overridden in Dog
        myDog.Bark();     // Overridden in Bulldog
        myDog.Play();     // Specific to Bulldog
        
        Console.WriteLine($"\nDog Name: {myDog.Name}");
        Console.WriteLine($"Breed: {myDog.Breed}");
        Console.WriteLine($"Color: {myDog.Color}");
    }
}
