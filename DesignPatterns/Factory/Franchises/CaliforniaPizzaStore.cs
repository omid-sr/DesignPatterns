using DesignPatterns.Factory.Franchises.Factories;
using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.Franchises;

public class CaliforniaPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {

        IPizzaIngredientFactory californiaIngredientsFactory = new NyPizzaIngredientFactory();
        return CaliforniaPizzaFactory.Create(type, californiaIngredientsFactory);
    }
}