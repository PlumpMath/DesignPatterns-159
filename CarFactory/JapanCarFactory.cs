using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
  public class JapanCarFactory: ICarFactory
  {
    public ICar Car
    { get; set; }

    public JapanCarFactory(ICar car)
    {
      this.Car = car;
    }

    void ICarFactory.buildSafetyMeasurements()
    {
      Car.SafetyMeasurements = "Best safety measurements in the world";
    }

    void ICarFactory.buildCarBody()
    {
      Car.CarBody = "Nice body.";
    }

    void ICarFactory.buildWindows()
    {
      Car.Windows = "Windows";
    }

    void ICarFactory.buildWheels()
    {
      Car.Wheels = "Wheels";
    }

    void ICarFactory.buildPersonalizationPackage()
    {
      Car.PersonalizationPackage = "We give you everything";
    }
  }
}
