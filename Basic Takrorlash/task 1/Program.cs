using System;

class Programm
{
  static void Main()
  {
    // task 1

    int number = 1;
    while (number <= 1001)
    {
      Console.WriteLine(number);
      number += 2;
    }

    int[] numbers = { 4, 2, 7, 8, 12, 9, 2, 9 };
    int max = numbers[0];
    int min = numbers[0];
    for (int num = 0; num < numbers.Length; num++)
    {
      if (numbers[num] > max)
      {
        max = numbers[num];
      }
      if (numbers[num] < min)
      {
        min = numbers[num];
      }
    }
    Console.WriteLine($"{min} x {max} = {min * max}");

    // task 3

    Console.Write("Butun son kiritng: ");
    int son = Convert.ToInt32(Console.ReadLine());

    int factor = 1;

    for (int i = 1; i <= son; i++)
    {
      factor = factor * i;
    }

    Console.WriteLine($"Natija: {factor}");

  }
}




