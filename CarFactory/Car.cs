using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
  public class Car : ICar
  {
    public String Name
    {
      get;
      set;
    }
    public String Wheels
    { get; set; }

    public String CarBody
    { get; set; }

    public String Windows
    { get; set; }

    public String SafetyMeasurements
    { get; set; }

    public String PersonalizationPackage
    { get; set; }
  }
}
