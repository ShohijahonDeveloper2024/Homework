using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("Tub emas");
            return;
        }

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {

            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? "Tub" : "Tub emas");

        // Task 2

        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool first = true;

        for (int i = 2; i <= 10; i++)
        {
            if (number % i == 0)
            {
                if (!first)
                {
                    Console.Write(", ");
                }


                Console.WriteLine(i);
                first = false;
            }
        }
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Bo'luvchilari: ");

        if (n % 2 == 0) Console.Write("2 ");
        if (n % 3 == 0) Console.Write("3 ");
        if (n % 4 == 0) Console.Write("4 ");
        if (n % 5 == 0) Console.Write("5 ");
        if (n % 6 == 0) Console.Write("6 ");
        if (n % 7 == 0) Console.Write("7 ");
        if (n % 8 == 0) Console.Write("8 ");
        if (n % 9 == 0) Console.Write("9 ");
        if (n % 10 == 0) Console.Write("10 ");
        // task 3

        Console.Write("Enter base number: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        double result = Math.Pow(baseNum, exponent);
        Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {result}");
        Console.Write("Enter your number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = number * number;
        Console.WriteLine($"The square of {number} is: {sum}");
        double sum2 = Math.Pow(number, 3);
        Console.WriteLine($"The cube of {number} is: {sum2}");
        // task 4; Armstrong numbers

        Console.Write("Enter a number: ");
        int number2 = int.Parse(Console.ReadLine());

        int original = number;
        int sum3 = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit * digit * digit;
            number /= 10;
        }

        if (sum == original)
            Console.WriteLine($"{original} Armstrong son");
        else
            Console.WriteLine($"{original} Armstrong son emas");

    }
}
