using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBuilder
{
  public abstract class PizzaBuilder : IPizzaBuilder
  {

    public Pizza Pizza
    {
      get;
      set;
    }

    #region Implementation of IPizzaBuilder

    public abstract void MakeDough();

    public abstract void SetTopping();

    public abstract void SetSauce();

    public abstract void Slice();

    public abstract void Box();


    #endregion
  }
}
