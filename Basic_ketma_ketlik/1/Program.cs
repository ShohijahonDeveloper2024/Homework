
//task 1
//1AreaOfTheCircle => formula : S=pi*radius^2
Console.Write("Enter your number for radius: ");
double radius = Convert.ToDouble(Console.ReadLine());
double areOfTheCircle = Math.PI * radius * radius;
System.Console.WriteLine($"The result of \"area of the circle\" is {areOfTheCircle}");
// Circumference of a circle => formula:L=2*pi*radius
double CircumferenceOfCircle = 2 * Math.PI * radius;
Console.WriteLine($"The result of \"Circumference of a circle\" is {CircumferenceOfCircle} ");

// Task 2
// Currency converter programm;

Console.Write("Enter amount in foreign currency: ");
double amount = Convert.ToDouble(Console.ReadLine());

double exchangeRate = 12400; // 1 unit of foreign currency = 12400 so'm

double convertedAmount = amount * exchangeRate;

Console.WriteLine($"Converted amount: {Math.Round(convertedAmount, 2)} so'm");

// Task 3 // Age calculation program;

Console.Write("Enter your birth year: ");
int birthYear = Convert.ToInt32(Console.ReadLine());
int currentYear = 2023;  // fixed year
int ageInYears = currentYear - birthYear;
int ageInDays = ageInYears * 365;
Console.WriteLine(ageInDays);









