using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
  public class NYPizzaStore : IPizzaStore
  {

    public Pizza CreatePizza(String type)
    {
    Pizza Pizza=null;
    IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

    if (type == "cheese")
    { 
      Pizza=new NYStyleCheesePizza(ingredientFactory);
      Pizza.Name = "New York style cheese pizza";
    }

  
    return Pizza;
    }


  }
}
