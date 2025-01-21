using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.PizzaTypes;

public class CheesePizza : Pizza
{
    public readonly IPizzaIngredientFactory PizzaIngredientFactory;
    public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        PizzaIngredientFactory = pizzaIngredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = PizzaIngredientFactory.CreateDough();
        Sauce = PizzaIngredientFactory.CreateSauce();
        Cheese = PizzaIngredientFactory.CreateCheese();
        Console.WriteLine("Prepare Cheese Pizza");
    }

    public virtual void Bake()
    {
        Console.WriteLine("Bake Cheese Pizza");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cut Cheese Pizza");
    }

    public virtual void Box()
    {
        Console.WriteLine("Box Cheese Pizza");
    }

}