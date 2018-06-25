using System;
using System.Collections.Generic;

class Cars
{
  private string _makeAndModel;
  private int _mileage;
  private int _cost;
  public void CarInfo()
  {
    Console.WriteLine("Make and Model: {0}", _makeAndModel);
    Console.WriteLine("Mileage: {0}", _mileage);
    Console.WriteLine("Cost: {0}", _cost);
  }

  public void SetMakeModel(string MakeAndModel)
  {
    _makeAndModel = MakeAndModel;
  }

  public string GetMakeModel()
  {
      return _makeAndModel;
  }

  public void SetMileage(int Mileage)
  {
    _mileage = Mileage;
  }

  public int GetMileage()
  {
      return _mileage;
  }

  public void SetCost(int Cost)
  {
    _cost = Cost;
  }

  public int GetCost()
  {
      return _cost;
  }
}

class Program
{
  public static void Main()
  {
    List<Cars> CarList = new List<Cars>();
    List<Cars> CarsUnderMaxPrice = new List<Cars>();

    Cars car1 = new Cars();
    car1.SetMakeModel("Toyota 4Runner");
    car1.SetMileage(20000);
    car1.SetCost(10000);

    Cars car2 = new Cars();
    car2.SetMakeModel("Honda Pilot");
    car2.SetMileage(25000);
    car2.SetCost(15000);

    CarList.Add(car1);
    CarList.Add(car2);

    Console.WriteLine("What is the max price");
    string StringMaxPrice = Console.ReadLine();
    int IntMaxPrice = int.Parse(StringMaxPrice);

    foreach (Cars automobile in CarList)
    {
      if(automobile.GetCost() <=  IntMaxPrice )
      {
        CarsUnderMaxPrice.Add(automobile);
      }
    }
    if(CarsUnderMaxPrice.Count < 1)
    {
      Console.WriteLine("There were no cars matching your price");
    }
    else
    {
      foreach (Cars matchedAuto in CarsUnderMaxPrice)
      {
        Console.WriteLine("{0} is at or under your max price", matchedAuto.GetMakeModel());
      }
    }
  }

}
