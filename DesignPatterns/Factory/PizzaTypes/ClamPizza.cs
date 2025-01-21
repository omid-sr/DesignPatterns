using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.PizzaTypes;

public class ClamPizza : Pizza
{
    public readonly IPizzaIngredientFactory PizzaIngredientFactory;

    public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        PizzaIngredientFactory = pizzaIngredientFactory;
    }

    public override void Prepare()
    {

        Console.WriteLine("Prepare Clam Pizza");
    }

    public virtual void Bake()
    {
        Console.WriteLine("Bake Clam Pizza");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cut Clam Pizza");
    }

    public virtual void Box()
    {
        Console.WriteLine("Box Clam Pizza");
    }

}