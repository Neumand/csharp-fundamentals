using System;
using System.Collections.Generic;
using GradeBook;

namespace Gradebook
{
  public delegate void GradedAddedDelegate(object sender, EventArgs args);
  public class NamedObject
  {
    public NamedObject(string name)
    {
      Name = name;
    }

    public string Name { get; set; }
  }
  public class Book : NamedObject
  {
    public Book(string name) : base(name)
    {
      grades = new List<double>();
      Name = name;
    }

    public void AddGrade(char letter)
    {
      switch (letter)
      {
        case 'A':
          AddGrade(90);
          break;
        case 'B':
          AddGrade(80);
          break;
        case 'C':
          AddGrade(70);
          break;
        case 'D':
          AddGrade(60);
          break;
        case 'F':
          AddGrade(0);
          break;
        default:
          AddGrade(0);
          break;
      }

    }
    public void AddGrade(double grade)
    {
      if (grade <= 100 & grade >= 0)
        grades.Add(grade);
      if (GradeAdded != null)
      {
        GradeAdded(this, new EventArgs());
      }
      else
      {
        throw new ArgumentException($"{grade} is not a valid grade. Please enter a grade between 0 and 100");
      }
    }

    public event GradedAddedDelegate GradeAdded;

    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average = 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;

      foreach (var grade in grades)
      {
        result.Low = Math.Min(grade, result.Low);
        result.High = Math.Max(grade, result.High);
        result.Average += grade;
      }

      result.Average /= grades.Count;
      switch (result.Average)
      {
        case var d when d >= 90.0:
          result.Letter = 'A';
          break;
        case var d when d >= 80.0:
          result.Letter = 'B';
          break;
        case var d when d >= 70.0:
          result.Letter = 'C';
          break;
        case var d when d >= 60.0:
          result.Letter = 'D';
          break;
        default:
          result.Letter = 'F';
          break;
      }

      return result;
    }

    private List<double> grades;

    public const string CATEGORY = "Science";
  }
}