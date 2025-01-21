using DesignPatterns.Factory.PizzaIngredients.CheeseModels;
using DesignPatterns.Factory.PizzaIngredients.ClamsModels;
using DesignPatterns.Factory.PizzaIngredients.DoughModels;
using DesignPatterns.Factory.PizzaIngredients.PepperoniModels;
using DesignPatterns.Factory.PizzaIngredients.SauceModels;
using DesignPatterns.Factory.PizzaIngredients.VeggiesModels;

namespace DesignPatterns.Factory.PizzaIngredients.Factories;

public class NyPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }
    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }
    public Cheese CreateCheese()
    {
        return new ReggianCheese();
    }
    public Veggies[] CreateVeggies()
    {
        Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        return veggies;
    }
    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }
    public Clams CreateClam()
    {
        return new FreshClams();
    }
}