using System;


// task 1
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

//task 2
Console.Write("Temperatura selseyasi uchun raqam kiriting: ");
double c = Convert.ToDouble(Console.ReadLine());

double f = 0;
double k = 0;

switch (1)
{
  case 1:
    f = (c * 9 / 5) + 32;
    k = c + 273.15;
    break;
}
Console.WriteLine($"Salsiyus: {c}");
Console.WriteLine($"Fahrenheilt: {f}");
Console.WriteLine($"Kelven: {k}");

// task 3

Console.Write("Sonlar kiriting (vergul bilan): ");
string numbers = Console.ReadLine();
string[] parts = numbers.Split(',');
int[] nums = Array.ConvertAll(parts, x => int.Parse(x.Trim()));
int[] asc = (int[])nums.Clone();
int[] desc = (int[])nums.Clone();

switch (1)
{
  case 1:
    Array.Sort(asc);
    Array.Sort(desc);
    Array.Reverse(desc);
    break;
}

Console.WriteLine("Tartiblangan qator:" + string.Join(",", asc));
Console.WriteLine("Teskari qator: " + string.Join(",", desc));

// task 4 

Console.Write("Matn kiritng: ");
string text = Console.ReadLine();

int[] count = new int[256];

switch (1)
{
  case 1:
    foreach (char t in text)
    {
      count[t]++;
    }
    break;
}

foreach (char t in text)
{
  if (count[t] != 0)
  {
    Console.WriteLine($"{t} : {count[t]} marta ");
    count[t] = 0;
  }
}