using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBuilder
{
  public class CheesePizzaBuilder : PizzaBuilder 
  {
    #region Implementation of IPizzaBuilder

    public override void MakeDough()
    {
      Pizza.Dough = "Thin crust";
    }

    public override void SetTopping()
    {
      Pizza.Topping = "Cheese";
    }

    public override void SetSauce()
    {
      Pizza.Sauce = "Marinara sauce";
    }

    public override void Slice()
    {
      Console.WriteLine("slice the pizza");
    }

    public override void Box()
    {
      Console.WriteLine("put pizza in box");
    }

    #endregion
  }
}
