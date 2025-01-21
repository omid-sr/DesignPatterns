using DesignPatterns.Factory.PizzaTypes.NewYork;

namespace DesignPatterns.Factory.Franchises.Factories;

public class ChicagoPizzaFactory
{
    public static Pizza Create(string type)
    {
        Pizza pizza = null;

        switch (type.ToLower())
        {
            case "cheese":
                pizza = new ChicagoCheesePizza();
                break;
            case "pepperoni":
                pizza = new ChicagoPepperoniPizza();
                break;
            case "clam":
                pizza = new ChicagoClamPizza();
                break;
            default:
                throw new ArgumentOutOfRangeException("Selected pizza is not available ");
        }
        return pizza;
    }
}