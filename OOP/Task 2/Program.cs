using System;
using Car.Project;

class Programm
{
  static void Main()
  {
    List<CarModel> cars = new List<CarModel>();
    // Ask user 5 times;
    for (int item = 0; item < 5; item++)
    {
      Console.WriteLine($"\nEnter #{item} car information:");

      Console.Write("Model: ");
      string model = Console.ReadLine();

      Console.Write("Color: ");
      string color = Console.ReadLine();

      Console.Write("Price: ");
      int price = Convert.ToInt32(Console.ReadLine());

      Console.Write("Speed: ");
      int speed = int.Parse(Console.ReadLine());

      Console.Write("year: ");
      int year = int.Parse(Console.ReadLine());

      // Create object
      CarModel car = new CarModel(model, color, price, speed, year);
      cars.Add(car);
    }

    // Show all cars

    Console.WriteLine("\n --- Cars info --- \n");

    foreach (var car in cars)
    {
      Console.WriteLine(car.GetInfo());
    }


  }
}