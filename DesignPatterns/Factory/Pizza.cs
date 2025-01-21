using DesignPatterns.Factory.PizzaIngredients.CheeseModels;
using DesignPatterns.Factory.PizzaIngredients.ClamsModels;
using DesignPatterns.Factory.PizzaIngredients.DoughModels;
using DesignPatterns.Factory.PizzaIngredients.PepperoniModels;
using DesignPatterns.Factory.PizzaIngredients.SauceModels;
using DesignPatterns.Factory.PizzaIngredients.VeggiesModels;

namespace DesignPatterns.Factory;

public abstract class Pizza
{
    public string Name { get; set; }

    public Dough Dough;
    public Sauce Sauce;
    public Veggies[] Veggies;
    public Cheese Cheese;
    public Pepperoni Pepperoni;
    public Clams Clam;
    public List<string> Toppings { get; set; } = new List<string>();
   public void SetName(String name)
    {
        Name = name;
    }
    public string GetName()
    {
        return Name;
    }
    public string ToString()
    {
        // code to print pizza here

        return Name;
    }

    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}