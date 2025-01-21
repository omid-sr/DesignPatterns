using DesignPatterns.Factory.PizzaIngredients.Factories;
using DesignPatterns.Factory.PizzaTypes;
using DesignPatterns.Factory.PizzaTypes.California;

namespace DesignPatterns.Factory.Franchises.Factories;

public class CaliforniaPizzaFactory
{
    public static Pizza Create(string type, IPizzaIngredientFactory ingredientFactory)
    {
        var pizza = Create(type, ingredientFactory);
        switch (type.ToLower())
        {

            case "pepperoni":
                pizza = new CaliforniaPepperoniPizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
                break;
            case "clam":
                pizza = new CaliforniaClamPizza(ingredientFactory);
                break;
            case "greek":
                pizza = new CaliforniaGreekPizza(ingredientFactory);
                break;
            case "veggie":
                pizza = new CaliforniaVeggiePizza(ingredientFactory);
                break;
            default:
                throw new ArgumentOutOfRangeException("Selected pizza is not available ");
        }
        return pizza;
    }
}