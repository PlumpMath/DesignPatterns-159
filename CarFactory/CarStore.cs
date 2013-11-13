using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
  public abstract class CarStore  
  {
    public abstract ICar CreateCar( ICarFactory carFactory);

    public ICar OrderCar(ICarFactory carFactory)
    {
      ICar car= CreateCar(carFactory);

      Console.WriteLine(car.Name);
      Console.WriteLine(car.CarBody);
      Console.WriteLine(car.PersonalizationPackage);
      Console.WriteLine(car.SafetyMeasurements);
      Console.WriteLine(car.Wheels);
      Console.WriteLine(car.Windows);
        

      return car;
    }
  }
}
