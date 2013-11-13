using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
  public abstract class Pizza
  {
    public string Name
    {
      get;
      set;
    }

    public Dough Dough
    {
      get;
      set;
    }
    public Veggies []Veggies
    {
    get;
    set;
    }
    public Cheese Cheese
    { get; set; }
    public Peperoni Peperoni
    { get; set; }
    public Clams Clams
    {
      get;
      set;
    }
    public Sauce Sauce { get; set; }
    public abstract void Prepare();

    public void Bake()
    {
      Console.WriteLine("Bake for 25 min at 350C");
    }

    public void Cut()
    {
      Console.WriteLine("Cutting the pizza into diagonal slices.");
    }

    public void Box()
    {
      Console.WriteLine("Place pizza in official pizza store box.");
    }

    void SetName(String name)
    {
      Name = name;
    }

    string GetName()
    {
      return Name;
    }

    public override String ToString()
    {
      return "Gutten appetit!";
    }
  }
}
