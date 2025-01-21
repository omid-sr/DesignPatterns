using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.PizzaTypes.California;

public class CaliforniaVeggiePizza : VeggiePizza
{
    public CaliforniaVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
    {
    }

    public override void Prepare()
    {
        Dough = PizzaIngredientFactory.CreateDough();
        Sauce = PizzaIngredientFactory.CreateSauce();
        Cheese = PizzaIngredientFactory.CreateCheese();
    }
}