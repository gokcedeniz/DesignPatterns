using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pizza
{
    public bool HasCheese { get; set; }
    public bool HasTomato { get; set; }
    public bool HasMushroom { get; set; }

    public void ShowIngredients()
    {
        Console.WriteLine("Pizza içeriği:");
        if (HasCheese) Console.WriteLine("Peynir");
        if (HasTomato) Console.WriteLine("Domates");
        if (HasMushroom) Console.WriteLine("Mantar");
    }
}

public class PizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public PizzaBuilder AddCheese()
    {
        _pizza.HasCheese = true;
        return this;
    }

    public PizzaBuilder AddTomato()
    {
        _pizza.HasTomato = true;
        return this;
    }

    public PizzaBuilder AddMushroom()
    {
        _pizza.HasMushroom = true;
        return this;
    }

    public Pizza Build()
    {
        return _pizza;
    }
}

namespace Builder_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new PizzaBuilder();

            Pizza pizza = builder
                .AddCheese()
                .AddTomato()
                .Build();

            pizza.ShowIngredients();

            Console.ReadLine();
        }
    }
}
