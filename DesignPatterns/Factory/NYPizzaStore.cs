namespace DesignPatterns.Factory;

public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        return CaliforniaPizzaFactory.Create(type);
    }
}


public class NYPizzaFactory
{
    public static Pizza Create(string type)
    {
        Pizza pizza = null;

        switch (type.ToLower())
        {
            case "cheese":
                pizza = new NYCheesePizza();
                break;
            case "pepperoni":
                pizza = new NYPepperoniPizza();
                break;
            case "clam":
                pizza = new NYClamPizza();
                break;
            case "greek":
                pizza = new NYGreekPizza();
                break;
            case "veggie":
                pizza = new NYVeggiePizza();
                break;
            default:
                throw new ArgumentOutOfRangeException("Selected pizza is not available ");
        }
        return pizza;
    }
}