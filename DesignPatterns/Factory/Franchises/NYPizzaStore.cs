using DesignPatterns.Factory.Franchises.Factories;
using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.Franchises;

public class NyPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {

        Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory =
            new NyPizzaIngredientFactory();
        return CaliforniaPizzaFactory.Create(type, ingredientFactory);
    }
}