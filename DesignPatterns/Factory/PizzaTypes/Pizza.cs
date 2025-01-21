namespace DesignPatterns.Factory;

public abstract class Pizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public List<string> Toppings { get; set; } = new List<string>();
    public virtual void Prepare()
    {
    }

    public virtual void Bake()
    {
    }

    public virtual void Cut()
    {
    }

    public virtual void Box()
    {
    }
}