using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
  class Program
  {
    static void Main(string[] args)
    {
      NYPizzaStore pizzaStore = new NYPizzaStore();
      Pizza pizza=pizzaStore.CreatePizza("cheese");
      pizza.Prepare();
      pizza.Bake();
      pizza.Cut();
      pizza.Box();

      Console.WriteLine(pizza.ToString());

      Console.ReadKey();

    }
  }
}
