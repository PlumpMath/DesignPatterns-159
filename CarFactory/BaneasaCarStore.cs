using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
  public class BaneasaCarStore : CarStore
  {
    public override ICar CreateCar(ICarFactory carFactory)
    {
      carFactory.buildCarBody();
      carFactory.buildSafetyMeasurements();
      carFactory.buildWheels();
      carFactory.buildWindows();
      carFactory.buildPersonalizationPackage();

      Console.WriteLine("Your car has been created!");

      return carFactory.Car;
    }
  }
}
