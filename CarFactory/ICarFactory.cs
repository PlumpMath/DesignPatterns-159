using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
  public interface ICarFactory
  {
    ICar Car
    { get; set; }

    void buildSafetyMeasurements();
    void buildPersonalizationPackage();
    void buildCarBody();
    void buildWindows();
    void buildWheels();
  }
}
