using System;
using System.Collections.Generic;

namespace GradeBook
{

  public class Book //Use classes to create objects
  {
    public Book(string name) //Constructor method
    {
      grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade) //Method called AddGrade (An instance member of a class)
    {
        grades.Add(grade);
    }
    public Stats GetStats() //void ShowStats removed for unit testing
    {
      var result = new Stats();
        result.Average = 0.0; //changed this line for unit testing (var result)
            result.High = double.MinValue; //changed this too (var highGrade)
            result.Low = double.MaxValue; //yep..this too (var lowGrade)

            foreach(var grade in grades) // took out number and added grade instead..
            {
               result.Low =  Math.Min(grade, result.Low); // lowGrade was here...were testing..
               result.High = Math.Max(grade, result.High); // highGrade was here..yep
               result.Average += grade;
            }

            result.Average /= grades.Count; //Commuting the average grade
            /*Console.WriteLine($"the lowest grade is {lowGrade}"); Commented this out, dont need to see 
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");*/ //The N:1 show grade with only 1 number after decimal
            return result;
    }

    private List<double> grades; // These fields are instance fields that are associated of object type book.
    private string name;
  }
}