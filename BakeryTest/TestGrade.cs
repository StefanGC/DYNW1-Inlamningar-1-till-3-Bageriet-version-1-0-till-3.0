using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BakeryTest
{
    [TestClass]
    public class TestGrade
    {
        [TestMethod]
        public void TestGrades()
        {
            // Arrange 
            Grade grade1 = new Grade("1", 1, 1);
            Grade grade2 = new Grade("2", 1, 2);
            Grade grade3 = new Grade("3", 1, 3);

            List<Grade> grades = new List<Grade>();
            grades.Add(grade1);
            grades.Add(grade2);
            grades.Add(grade3);

            // Act
            double expected = 3.0;
            double result = 0.0;
            foreach (Grade grad in grades)
            {
                result += grad.Grad;
            }
            result = result / grades.Count;

            //Assert
            Assert.Equals(expected, result);
        }
    }
}
