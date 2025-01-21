using DesignPatterns.Factory.PizzaIngredients.Factories;

namespace DesignPatterns.Factory.PizzaTypes.California;

public class CaliforniaClamPizza : ClamPizza
{
    public CaliforniaClamPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
    {
    }

    public override void Prepare()
    {
        Dough = PizzaIngredientFactory.CreateDough();
        Sauce = PizzaIngredientFactory.CreateSauce();
        Cheese = PizzaIngredientFactory.CreateCheese();
    }
}