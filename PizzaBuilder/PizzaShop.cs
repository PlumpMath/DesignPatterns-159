using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBuilder
{
  public class PizzaShop
  {
    private PizzaBuilder pizzaBuilder;

    public PizzaShop(PizzaBuilder pizzaBuilder)
    {
      this.pizzaBuilder = pizzaBuilder;
    }

    public void OrderPizza()
    {
      pizzaBuilder.Pizza=new Pizza();

      pizzaBuilder.MakeDough();
      pizzaBuilder.SetSauce();
      pizzaBuilder.SetTopping();


      Console.WriteLine(pizzaBuilder.Pizza.Dough);
      Console.WriteLine(pizzaBuilder.Pizza.Sauce);
      Console.WriteLine(pizzaBuilder.Pizza.Topping);

      pizzaBuilder.Box();
      pizzaBuilder.Slice();

      Console.WriteLine("You are served!");
    }

  }
}
