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

    List<double> grades;
  }
}