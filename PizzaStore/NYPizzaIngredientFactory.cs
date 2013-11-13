using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
  public class NYPizzaIngredientFactory : IPizzaIngredientFactory
  {
    public Dough CreateDough()
    {
      Console.WriteLine("new thin crust dough");
      return new Dough();
    }

    public Cheese CreateCheese()
    {
      Console.WriteLine("fresh mozzarella");

      return new Cheese();
     
    }

    public Veggies[] CreateVeggies()
    {
      Console.WriteLine("fresh veggies");

      return new Veggies[]{};

    }

    public Peperoni CreatePeperoni()
    {
      Console.WriteLine("fresh peperoni");
      return new Peperoni();
    }

    public Clams CreateClams()
    {
      Console.WriteLine("fresh clams");
      return new Clams();
    }


    public Sauce CreateSauce()
    {
      Console.WriteLine("special new york sauce");
      return new Sauce();
    }
  }
}
