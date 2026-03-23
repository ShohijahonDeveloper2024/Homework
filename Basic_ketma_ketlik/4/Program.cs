using System;

class Program
{
  static void Main()
  {
    Console.Write("Iltimos, bitta harf kiriting: ");
    char belgi = Convert.ToChar(Console.ReadLine());

    bool UpperLatter = belgi >= 'A' && belgi <= 'Z';
    Console.WriteLine(UpperLatter ? "HA" : "YO'Q");

    // task 2

    Console.Write("Dasturlash sizga yoqadimi? (h/y): ");
    char text = Convert.ToChar(Console.ReadLine());

    bool dastur = text == 'h' || text == 'H';
    Console.WriteLine(dastur ? "Ajoyib!" : "Afsus!");

    // task  3

    Console.Write("Ismingizni kiriting: ");
    string ism = Console.ReadLine();

    char firstLatter = ism[0];
    Console.WriteLine($"{ism}ning birinchi harfi => \"{firstLatter}\" harfiga teng!");
  }
}