namespace DesignPatterns.Factory;

public class ClamPizza : Pizza
{
    public virtual void Prepare()
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