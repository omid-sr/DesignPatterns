using DesignPatterns.Factory.Franchises.Factories;
using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.Franchises;

public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        IPizzaIngredientFactory chicagoPizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
        return CaliforniaPizzaFactory.Create(type, chicagoPizzaIngredientFactory);
    }
}