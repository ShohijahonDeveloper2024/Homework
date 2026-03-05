// task 1
// Calculator programm;
Console.Write("Type your 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Type your 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
// task 2  The sum of numbers up to 10
Console.Write("Enter a positive integer: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
}

Console.WriteLine($"The sum of numbers from 1 to {n} is {sum}");

//task 3  A program that determines whether a number is even or odd
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even");
}
else if (number % 2 != 0)
{
    Console.WriteLine($"{number} is odd");
}
else
{
    Console.WriteLine("The number is 0");
}


