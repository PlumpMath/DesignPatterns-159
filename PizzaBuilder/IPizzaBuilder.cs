using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBuilder
{
  public interface IPizzaBuilder
  {
    void MakeDough();
    void SetTopping();
    void SetSauce();
    void Slice();
    void Box();
  }
}
