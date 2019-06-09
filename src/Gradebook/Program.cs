// Tells the C# compiler that it should be looking in these namespaces
using System;
using System.Collections.Generic;

namespace Gradebook
{
  class Program
  {
    static void Main(string[] args)
    {
      var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
      grades.Add(56.1);
      var result = 0.0;
      foreach (var grade in grades)
      {
        result += grade;
      }
      var average = result / grades.Count;
      Console.WriteLine($"The sum of all grades is {result:N2}");
      Console.WriteLine($"The average grade is {average:N2}");

      if (args.Length > 0)
      {
        Console.WriteLine($"Hello, {args[0]}!");
      }
      else
      {
        Console.WriteLine("Hello!");
      }
    }
  }
}
