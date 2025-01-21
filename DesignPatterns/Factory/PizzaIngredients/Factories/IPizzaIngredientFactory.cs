using DesignPatterns.Factory.PizzaIngredients.CheeseModels;
using DesignPatterns.Factory.PizzaIngredients.ClamsModels;
using DesignPatterns.Factory.PizzaIngredients.DoughModels;
using DesignPatterns.Factory.PizzaIngredients.PepperoniModels;
using DesignPatterns.Factory.PizzaIngredients.SauceModels;
using DesignPatterns.Factory.PizzaIngredients.VeggiesModels;

namespace DesignPatterns.Factory.PizzaIngredients.Factories;

public interface IPizzaIngredientFactory
{
    public Dough CreateDough();
    public Sauce CreateSauce();
    public Cheese CreateCheese();
    public Veggies[] CreateVeggies();
    public Pepperoni CreatePepperoni();
    public Clams CreateClam();
}