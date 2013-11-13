using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
  public class RomaniaCarFactory : ICarFactory
  {
    public ICar Car
    { get; set; }

    public RomaniaCarFactory(ICar car)
    {
      this.Car = car;
    }

    void ICarFactory.buildSafetyMeasurements()
    {
      Car.SafetyMeasurements = "There are no safety measurements for romanian cars.";
    }

    void ICarFactory.buildCarBody()
    {
      Car.CarBody = "Plastic carosery.";
    }

    void ICarFactory.buildWindows()
    {
      Car.Windows = "Windows are overrated";
    }

    void ICarFactory.buildWheels()
    {
      Car.Wheels = "Flinstone style .. it's good for your health also";
    }

    void ICarFactory.buildPersonalizationPackage()
    {
      Car.PersonalizationPackage = "Color can be only navy blue for this price";
    }
  }
}
