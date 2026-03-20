using System;

class Program
{
  static void Main()
  {
    // task 1

    /*Console.Write("Type something you like: ");
    string word = Console.ReadLine();
    Console.Write("Type number:  ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > word.Length)
    {
      Console.WriteLine(word.ToUpper());
    }
    else if (number == word.Length)
    {
      Console.WriteLine(word = char.ToUpper(word[0]) + word.Substring(1));
    }
    else
    {
      Console.WriteLine(word.ToLower());
    }

    // task 2

    Console.Write("Type 1st number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Type 2nd number: ");
    int y = Convert.ToInt32(Console.ReadLine());

    string result = (x > y)
      ? $"{x} > {y}"
      : (x < y)
        ? $"{x} < {y} "
        : (x == y)
          ? $"{x} = {y}"
          : $"{x} and {y} are not comparable";

    Console.WriteLine(result);
     */
    // task 3
    Console.Write("Type the number of the day of the week: ");
    string days = Console.ReadLine();
    switch (days)
    {
      case "1":
        Console.WriteLine("Monday => \"Dushanba\"");
        break;
      case "2":
        Console.WriteLine("Tuesday => \"Seshanba\"");
        break;
      case "3":
        Console.WriteLine("Wednesday => \"Chorshanba\"");
        break;
      case "4":
        Console.WriteLine("Thursday => \"Payshanba\"");
        break;
      case "5":
        Console.WriteLine("Friday => \"Juma\"");
        break;
      case "6":
        Console.WriteLine("Saturday => \"Shanba\"");
        break;
      case "7":
        Console.WriteLine("Sunday => \"Yakshanba\"");
        break;
      default:
        Console.WriteLine("Eror: The number of the day Not Found!");
        break;
    }

    string day = days switch
    {
      "1" => "Monday => \"Dushanba\"",
      "2" => "Tuesday => \"Seshanba\"",
      "3" => "Wednesday => \"Chorshanba\"",
      "4" => "Thurday => \"Payshanba \"",
      "5" => "Friday => \"Juma\"",
      "6" => "Saturday => \"Shanba\"",
      "7" => "Sunday => \"Yakshanba\"",
      _ => "Eror: The number of the day of the week Not Found!"

    };
    Console.WriteLine(day);

    Console.Write("Type the number of the month which you like: ");
    string months = Console.ReadLine();
    string month = "";

    switch (months)
    {
      case "1":
        month = "January ";
        break;
      case "2":
        month = "February";
        break;
      case "3":
        month = "March ";
        break;
      case "4":
        month = "April";
        break;
      case "5":
        month = "May";
        break;
      case "6":
        month = "June";
        break;
      case "7":
        month = "July";
        break;
      case "8":
        month = "August";
        break;
      case "9":
        month = "September";
        break;
      case "10":
        month = "October";
        break;
      case "11":
        month = "November";
        break;
      case "12":
        month = "December";
        break;
      default:
        month = $"{month} - is not found!";
        break;
    }

    Console.WriteLine(month);

    string countOfMonths = months switch
    {
      "1" => "1 - January",
      "2" => "2 - February",
      "3" => "3 - March",
      "4" => "4 - April",
      "5" => "5 - May",
      "6" => "6 - June",
      "7" => "7 - July",
      "8" => "8 - August",
      "9" => "9 - September",
      "10" => "10 - October",
      "11" => "11 - November",
      "12" => "12 - December",
      _ => "Eror: Range of the number The number that you type is not fond!"
    };
    Console.WriteLine(countOfMonths);

  }
}