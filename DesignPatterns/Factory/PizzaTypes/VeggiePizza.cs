namespace DesignPatterns.Factory.PizzaTypes;

public class VeggiePizza : Pizza
{
    public virtual void Prepare()
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