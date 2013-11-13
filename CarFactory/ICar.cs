using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
  public interface ICar
  {
     String Name
    {
      get;
      set;
    }
     String Wheels
    { get; set; }

     String CarBody
    { get; set; }

     String Windows
    { get; set; }

     String SafetyMeasurements
    { get; set; }

     String PersonalizationPackage
    { get; set; }
  }
}
