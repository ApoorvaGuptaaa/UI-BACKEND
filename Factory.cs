using System;

public interface IAnimal
{
    void Speak();
}

public class Dog : IAnimal {
    public void Speak() {
        Console.WriteLine("Woof");
    }
}
public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow");
    }
}

public class AnimalFactory
{
    public IAnimal CreateAnimal(string animalType)
    {
        return animalType.ToLower() switch
        {
            "dog" => new Dog(),
            "cat" => new Cat(),
            _ => throw new ArgumentException("Invalid animal type")
        };
    }
}

var animal = new AnimalFactory();
IAnimal animal1 = new AnimalFactory("dog");
animal.CreateAnimal();