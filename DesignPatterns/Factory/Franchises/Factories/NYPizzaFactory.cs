namespace DesignPatterns.Factory.Franchises.Factories;

public class NyPizzaFactory
{
    public static Pizza Create(string type)
    {
        Pizza pizza = null;

        switch (type.ToLower())
        {
            case "cheese":
                pizza = new NyCheesePizza();
                break;
            case "pepperoni":
                pizza = new NyPepperoniPizza();
                break;
            case "clam":
                pizza = new NyClamPizza();
                break;
            case "greek":
                pizza = new NyGreekPizza();
                break;
            case "veggie":
                pizza = new NyVeggiePizza();
                break;
            default:
                throw new ArgumentOutOfRangeException("Selected pizza is not available ");
        }
        return pizza;
    }
}

public class NyVeggiePizza : Pizza
{
    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}

public class NyGreekPizza : Pizza
{
    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}

public class NyClamPizza : Pizza
{
    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}

public class NyPepperoniPizza : Pizza
{
    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}

public class NyCheesePizza : Pizza
{
    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}