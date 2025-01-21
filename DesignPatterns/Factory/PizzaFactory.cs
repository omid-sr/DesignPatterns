using DesignPatterns.Factory.PizzaTypes;

namespace DesignPatterns.Factory;

public abstract class PizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza = null;

        switch (type.ToLower())
        {
            case "cheese":
                pizza = new CheesePizza();
                break;
            case "pepperoni":
                pizza = new PepperoniPizza();
                break;
            case "clam":
                pizza = new ClamPizza();
                break;
            case "greek":
                pizza = new GreekPizza();
                break;
            case "veggie":
                pizza = new VeggiePizza();
                break;
            default:
                throw new ArgumentOutOfRangeException("Selected pizza is not available ");
        }
        return pizza;
    }
}