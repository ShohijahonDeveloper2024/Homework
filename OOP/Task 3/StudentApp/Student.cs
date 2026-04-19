using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentApp
{
  public enum Grade
  {
    A,
    B,
    C,
    D,
    Fx,
    F,

  }



  public class Student
  {
    public Guid Id { get; set; }
    public string Ism { get; set; }
    public string Familiya { get; set; }
    public int Kurs { get; set; }
    public Grade Baho { get; set; }

    public Student(
      string ism,
      string familya,
      int kurs,
      Grade baho)
    {
      Ism = ism;
      Familiya = familya;
      Kurs = kurs;
      Baho = baho;
    }



  }
}