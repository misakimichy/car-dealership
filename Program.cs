using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "I am the Volks Wagen!");
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, "I am yugo.");
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Here Ford comes!");
      Car amc = new Car("1976 AMC Pacer", 400, 198000, "Hey ya! I'm amc!");

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
      yugo.SetPrice(300);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarMatchingSearch = new List<Car>(0);

      foreach(Car automobile in Cars)
      {
        if(automobile.WorthBuying(maxPrice))
        {
          CarMatchingSearch.Add(automobile);
        }
      }

      if (CarMatchingSearch.Count == 0)
      {
        Console.WriteLine("No cars match your criteria.");
      }
      else{
        foreach(Car automobile in CarMatchingSearch)
        {
          Console.WriteLine("----------------------");
          Console.WriteLine(automobile.GetMakeModel());
          Console.WriteLine(automobile.GetMiles() + " miles");
          Console.WriteLine("$" + automobile.GetPrice());
          Console.WriteLine("Message from this car: " + automobile.GetMessage());
        }
      }
    }
  }
}