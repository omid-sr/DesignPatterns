namespace DesignPatterns.Factory;

public class CheesePizza : Pizza
{
    public virtual void Prepare()
    {

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

    public CheesePizza()
    {
    }
}