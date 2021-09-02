using System;
using System.Collections.Generic;

namespace GradeBook
{

  class Book //Use classes to create objects
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
    public void ShowStats()
    {
       var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades) 
            {
               lowGrade =  Math.Min(number, lowGrade);
               highGrade = Math.Max(number, highGrade);
               result += number;
            }

            result /= grades.Count; //Commuting the average grade
            Console.WriteLine($"the lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}"); //The N:1 show grade with only 1 number after decimal
    }

    private List<double> grades; // These fields are instance fields that are associated of object type book.
    private string name;
  }
}