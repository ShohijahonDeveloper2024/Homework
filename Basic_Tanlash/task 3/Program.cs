using System;
using System.Reflection.Metadata;

class Program
{
  static void Main()
  {
    Console.Write("So'z kiriting: ");
    string input = Console.ReadLine();

    // Reverse using built-in method
    char[] arr = input.ToCharArray();
    Array.Reverse(arr);
    string reversed = new string(arr);

    // Check with if-else
    if (input.ToLower() == reversed.ToLower())
    {
      Console.WriteLine("Palindrom");
    }
    else
    {
      Console.WriteLine("Palindrom emas");
    }

    string message =
      (input.ToLower() == reversed.ToLower())
        ? $"\"{input.ToUpper()}\"- Palindrom!"
        : $"\"{input.ToUpper()}\"- Not Palindrom!";
    Console.WriteLine(message);
  }
}