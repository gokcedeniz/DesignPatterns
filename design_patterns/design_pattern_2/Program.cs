using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//creational patterns: Factory method
public abstract class Animal
{
    public abstract void Move();
}

public class Dog : Animal
{
    public override void Move()
    {
        Console.WriteLine("Walking!");
    }
}

public class Bird : Animal
{
    public override void Move()
    {
        Console.WriteLine("Flying!");
    }
}

public class AnimalFactory
{
    public static Animal GetAnimal(string type)
    {
        if (type == "dog") return new Dog();
        if (type == "bird") return new Bird();
        return null;
    }
}
namespace design_pattern_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = AnimalFactory.GetAnimal("dog");
            animal1.Move(); 

            Animal animal2 = AnimalFactory.GetAnimal("bird");
            animal2.Move();

            Console.ReadLine();
        }
    }
}

