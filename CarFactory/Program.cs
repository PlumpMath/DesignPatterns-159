using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      CarStore carStore=new BaneasaCarStore();
      ICarFactory carFactory = new RomaniaCarFactory(new DaciaCar("Logan"));
      carStore.OrderCar(carFactory);

      Console.WriteLine();
      Console.WriteLine("____________________________");
      Console.WriteLine();
     
      carFactory = new JapanCarFactory(new ToyotaCar("Avensis"));
      carStore.OrderCar(carFactory);

      Console.ReadKey();
    }
  }
}
