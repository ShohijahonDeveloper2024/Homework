using System;


class Program
{
  static void Main()
  {
    List<string> tasks = new List<string>();
    List<bool> done = new List<bool>();

    while (true)
    {
      Console.WriteLine("\n1 - Vazifa qo'shish");
      Console.WriteLine("2 - Vazifani o'chirish");
      Console.WriteLine("3 - Bajarildi deb belgilash");
      Console.WriteLine("4 - Vazifalarni ko'rish");
      Console.WriteLine("0 - Chiqish");

      Console.Write("Tanlang: ");
      int choice = int.Parse(Console.ReadLine());

      if (choice == 1)
      {
        Console.Write("Vazifa kiriting: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        done.Add(false);
      }
      else if (choice == 2)
      {
        Console.Write("O'chiriladigan index: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < tasks.Count)
        {
          tasks.RemoveAt(index);
          done.RemoveAt(index);
        }
      }
      else if (choice == 3)
      {
        Console.Write("Bajarilgan index: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < done.Count)
        {
          done[index] = true;
        }
      }
      else if (choice == 4)
      {
        Console.WriteLine("\nVazifalar:");

        for (int i = 0; i < tasks.Count; i++)
        {
          string status = done[i] ? "✔" : "❌";
          Console.WriteLine(i + " - " + tasks[i] + " [" + status + "]");
        }
      }
      else if (choice == 0)
      {
        break;
      }
    }
  }
}