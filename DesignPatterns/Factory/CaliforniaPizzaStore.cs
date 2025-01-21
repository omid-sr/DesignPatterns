namespace DesignPatterns.Factory;

public class CaliforniaPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        return CaliforniaPizzaFactory.Create(type);
    }
}

public class CaliforniaPizzaFactory
{
    public static Pizza Create(string type)
    {
        var pizza = CaliforniaPizzaFactory.Create(type);
        switch (type.ToLower())
        {
            case "cheese":
                pizza = new CaliforniaCheesePizza();
                break;
            case "pepperoni":
                pizza = new CaliforniaPepperoniPizza();
                break;
            case "clam":
                pizza = new CaliforniaClamPizza();
                break;
            case "greek":
                pizza = new CaliforniaGreekPizza();
                break;
            case "veggie":
                pizza = new CaliforniaVeggiePizza();
                break;
            default:
                throw new ArgumentOutOfRangeException("Selected pizza is not available ");
        }
        return pizza;
    }
}