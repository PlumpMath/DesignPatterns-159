using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
  public interface IPizzaIngredientFactory
  {
     Dough CreateDough();
     Cheese CreateCheese();
     Veggies[] CreateVeggies();
     Peperoni CreatePeperoni();
     Clams CreateClams();

     Sauce CreateSauce();
  }
}
