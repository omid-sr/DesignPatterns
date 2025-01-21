namespace DesignPatterns.Factory;

public class PepperoniPizza : Pizza
{
    public virtual void Prepare()
    {

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