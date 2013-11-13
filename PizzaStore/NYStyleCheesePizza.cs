using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
  public class NYStyleCheesePizza : Pizza
  {
    IPizzaIngredientFactory ingredientFactory;

    public NYStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
    {
      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("preparing" + Name);
      Dough = ingredientFactory.CreateDough();
      Sauce = ingredientFactory.CreateSauce();
    }
  }
}
