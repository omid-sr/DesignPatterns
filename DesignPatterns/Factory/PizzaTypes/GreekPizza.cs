namespace DesignPatterns.Factory;

public class GreekPizza : Pizza
{

    public virtual void Prepare()
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