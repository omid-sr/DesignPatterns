using DesignPatterns.Factory.PizzaIngredients.CheeseModels;
using DesignPatterns.Factory.PizzaIngredients.DoughModels;
using DesignPatterns.Factory.PizzaIngredients.Factories;
using DesignPatterns.Factory.PizzaIngredients.SauceModels;

namespace DesignPatterns.Factory.PizzaTypes.California;

public class CaliforniaPepperoniPizza : PepperoniPizza
{

    public CaliforniaPepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
    {
    }

  public override void Prepare()
    {
        Dough = PizzaIngredientFactory.CreateDough();
        Sauce = PizzaIngredientFactory.CreateSauce();
        Cheese = PizzaIngredientFactory.CreateCheese();
    }
}