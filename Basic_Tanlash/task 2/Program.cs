using System;
class Task_2
{
  static void Main()
  {

    // task 1
    Console.Write("Type number : ");
    string input = Console.ReadLine();
    int minutes;

    // Try to convert input to integer
    if (int.TryParse(input, out minutes))
    {
      // Valid integer → continue program
      int hours = minutes / 60;
      int remainingMinutes = minutes % 60;

      Console.WriteLine($"Time: {hours}:{remainingMinutes:D2}");
    }
    else
    {
      // Invalid input (string, double, bool, etc.)
      Console.WriteLine("Error: Please type a valid whole number!");
    }

    // task 2
    Console.Write("Please type your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age < 2)
    {
      Console.WriteLine($"You are {age} and you are a baby ");
    }
    else if (age < 5)
    {
      Console.WriteLine($"You are {age} and you are a todler!");
    }
    else if (age <= 12)
    {
      Console.WriteLine($"you are {age} and you are a child! ");
    }
    else if (age <= 19)
    {
      Console.WriteLine($"You are {age} and you are a teenager!");
    }
    else if (age <= 64)
    {
      Console.WriteLine($"You are {age} and you are an adult");
    }
    else
    {
      Console.WriteLine($"You are {age} and you are a senior");
    }
    // task 3

    string exam = "";
    Console.Write("Enter your score to get your exam result: ");
    int score = Convert.ToInt32(Console.ReadLine());
    string result = (score > 90 && score <= 100)
       ? exam = $"You got {score}. It's \"A\". You passed the exam! Awesome score!"
       : (score >= 76 && score < 90)
          ? exam = $"You got {score}. It's \"B\". You passed the exam! Good score!"
          : exam = (score >= 50 && score < 76)
            ? exam = $"You got {score}. It's \"C\". You passed the exam."
            : (score >= 45 && score < 50)
              ? $"You got {score}. It's \"Fx\". You failed the exam, but you can retake it for free."
              : (score >= 0 && score < 45)
               ? $"You got {score}. It's \"F\". You failed the exam and cannot retake it for free."
               : "Error: score out of range";

    Console.WriteLine(result);

    // task 4

    Random random = new Random();
    int secretNumber = random.Next(1, 101);
    Console.WriteLine("Type your number including the numbers (1, 101): ");
    int guest = Convert.ToInt32(Console.ReadLine());
    string numbers =
      (secretNumber > guest)
        ? $"{secretNumber} > {guest}"
        : (secretNumber < guest)
          ? $"{secretNumber} < {guest}"
          : $"Congratulations you find the number {secretNumber} = {guest}";

    Console.WriteLine($"Final result {numbers} ");

  }
}














