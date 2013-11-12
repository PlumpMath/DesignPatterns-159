using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBuilder
{
  class Program
  {
    static void Main(string[] args)
    {
      
      PizzaBuilder pizzaBuilder = new CheesePizzaBuilder();
      PizzaShop shop = new PizzaShop(pizzaBuilder);


      shop.OrderPizza();

      Console.ReadKey();
    }
  }
}
