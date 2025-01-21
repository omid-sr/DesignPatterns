using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.PizzaTypes;

public class VeggiePizza : Pizza
{

    public IPizzaIngredientFactory PizzaIngredientFactory;

    public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        PizzaIngredientFactory = pizzaIngredientFactory;
    }

    public override void Prepare()
    {

        Console.WriteLine("Prepare Veggie Pizza");
    }

    public virtual void Bake()
    {
        Console.WriteLine("Bake Veggie Pizza");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cut Veggie Pizza");
    }

    public virtual void Box()
    {
        Console.WriteLine("Box Veggie Pizza");
    }

}