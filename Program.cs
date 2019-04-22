using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 7864, "Great");
      Car ford = new Car("2011 Ford F450", 55995, 14241, "Wonderful");
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "Excellent choice");
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "Perfect");

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

      lexus.SetPrice(2000);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Enter maximum mileage: ");
      string stringMaxMileage = Console.ReadLine();
      int maxMileage = int.Parse(stringMaxMileage);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice, maxMileage))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      if (CarsMatchingSearch.Count == 0)
      {
        Console.WriteLine("No cars are matching your search.");
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
        Console.WriteLine(automobile.GetMessage());
      }
    }
  }

}
