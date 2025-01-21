using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.PizzaTypes;

public class PepperoniPizza : Pizza
{

    public IPizzaIngredientFactory PizzaIngredientFactory;
    public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        PizzaIngredientFactory = pizzaIngredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = PizzaIngredientFactory.CreateDough();
        Sauce = PizzaIngredientFactory.CreateSauce();
        Cheese = PizzaIngredientFactory.CreateCheese();
        Console.WriteLine("Prepare Pepperoni Pizza");
    }
  
    public virtual void Bake()
    {
        Console.WriteLine("Bake Pepperoni Pizza");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cut Pepperoni Pizza");
    }

    public virtual void Box()
    {
        Console.WriteLine("Box Pepperoni Pizza");
    }


}