// Tells the C# compiler that it should be looking in these namespaces
using System;
using System.Collections.Generic;

// Avoids conflicts with types and classes that are defined by Microsoft libraries, for example.
namespace Gradebook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("David's Grade Book");

      while (true)
      {
        Console.WriteLine("Enter a grade or 'q' to quit");
        var input = Console.ReadLine();
        if (input == "q")
        {
          break;
        }

        try
        {
          var grade = double.Parse(input);
          book.AddGrade(grade);
        }
        catch (Exception exception)
        {
          Console.WriteLine(exception.Message);
        }
      }

      book.GetStatistics();

      var stats = book.GetStatistics();

      // Console Outputs
      Console.WriteLine($"The lowest grade is {stats.Low:N2}");
      Console.WriteLine($"The highest grade is {stats.High:N2}");
      Console.WriteLine($"The average grade is {stats.Average:N2}");
      Console.WriteLine($"The letter grade is {stats.Letter}");
    }
  }
}
