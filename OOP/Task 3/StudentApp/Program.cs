using System;
namespace StudentApp
{
  internal class Program
  {
    static void Main()
    {
      List<Student> students = new List<Student>()
      {
      new Student("Ali", "Qodirov", 2, Grade.A),
      new Student("Shohijahon", "Rahmonov", 3, Grade.B),
      new Student("Dilnoza", "Asqarova", 1, Grade.A),
      new Student("Dilshod", "Hasanov", 4, Grade.C),
      new Student("Nargiza", "Akramova", 5, Grade.B),
      new Student("Abbos", "Botirovv", 1, Grade.Fx),
      new Student("Anvar", "Azamatov", 2, Grade.D),
      new Student("Ahror", "Qahhorov", 3, Grade.F),
      new Student("Avazjon", "Alijonov", 1, Grade.B)
      };
      Console.Write("Enter grade (A, B, C, D, F, Fx): ");
      string input = Console.ReadLine().ToUpper();

      if (Enum.TryParse(input, out Grade selectedGrade))
      {
        var result = students.Where(s => s.Baho == selectedGrade).ToList();
        Console.WriteLine($"Students with grade {selectedGrade}: ");
        if (result.Count == 0)
        {
          Console.WriteLine("No student Found!");
        }
        else
        {
          foreach (var student in result)
          {
            Console.WriteLine($"{student.Kurs} - kurs talabasi {student.Familiya} {student.Ism}ning bahosi \"{student.Baho}\" ");
          }
        }

      }
      else
      {
        Console.WriteLine("Invalid Grade entered!");
      }
    }
  }
}