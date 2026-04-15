namespace Car.Project
{
  public class CarModel
  {
    public string Model { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public int Speed { get; set; }
    public int Year { get; set; }

    public CarModel(
      string model,
      string color,
      decimal price,
      int speed,
      int year)
    {
      Model = model;
      Color = color;
      Price = price;
      Speed = speed;
      Year = year;
    }

    public string GetInfo()
    {
      return $"{Color} {Model} | Price: {Price}$ | Year: {Year} | Speed: {Speed} km/h";
    }
  }
}