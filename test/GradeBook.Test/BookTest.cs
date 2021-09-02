using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        [Fact] //An attribute
        public void Test1()
        {   
            // Arrange
           var book = new Book("");
           book.AddGrade(89.1);
           book.AddGrade(90.5);
           book.AddGrade(77.3);

            // Act
           var result = book.GetStats();

            // Assert
            Assert.Equal(85.6, result.Average, 1); // These lines I added another paran passed to go 1 decimal place.
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
