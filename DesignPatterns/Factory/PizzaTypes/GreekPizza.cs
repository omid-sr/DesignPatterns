using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.PizzaTypes;

public class GreekPizza : Pizza
{
    public readonly IPizzaIngredientFactory PizzaIngredientFactory;

    public GreekPizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        PizzaIngredientFactory = pizzaIngredientFactory;
    }

    public override void Prepare()
    {

        Console.WriteLine("Prepare Greek Pizza");
    }

    public virtual void Bake()
    {
        Console.WriteLine("Bake Greek Pizza");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cut Greek Pizza");
    }

    public virtual void Box()
    {
        Console.WriteLine("Box Greek Pizza");
    }

}