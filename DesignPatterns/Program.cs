using DesignPatterns.Factory.Franchises;
using DesignPatterns.Factory;

PizzaStore nyPizzaStore = new NyPizzaStore();

nyPizzaStore.OrderPizza("pepperoni");

Pizza pizza = nyPizzaStore.CreatePizza("pepperoni");