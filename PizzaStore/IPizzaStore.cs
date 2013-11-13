using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
  public interface IPizzaStore
  {
    Pizza CreatePizza(String type);

  }
}
