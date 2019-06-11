using System;
using System.Collections.Generic;

namespace Gradebook
{
  class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatistics()
    {
      var result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;

      foreach (var grade in grades)
      {
        lowGrade = Math.Min(grade, lowGrade);
        highGrade = Math.Max(grade, highGrade);
        result += grade;
      }

      var average = result / grades.Count;

      // Console Outputs
      Console.WriteLine($"The lowest grade is {lowGrade}");
      Console.WriteLine($"The highest grade is {highGrade}");
      Console.WriteLine($"The sum of all grades is {result:N2}");
      Console.WriteLine($"The average grade is {average:N2}");
    }

    List<double> grades;
  }
}