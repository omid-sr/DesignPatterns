namespace DesignPatterns.Factory;

public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        return CaliforniaPizzaFactory.Create(type);
    }
}
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
            case "greek":
                pizza = new ChicagoGreekPizza();
                break;
            case "veggie":
                pizza = new ChicagoVeggiePizza();
                break;
            default:
                throw new ArgumentOutOfRangeException("Selected pizza is not available ");
        }
        return pizza;
    }
}