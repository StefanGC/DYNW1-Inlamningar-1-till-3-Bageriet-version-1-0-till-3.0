using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BakeryTest
{
    [TestClass]
    public class TestBreadView
    {
        [TestMethod]
        public void TestBreadRepository()
        {
            //Arrange
            IBreadRepository breadRepository = new MockBreadRepository();

            //Act
            int breadCount = (breadRepository.AllBreads as List<Bread>).Count;

            //Assert
            Assert.AreNotEqual(breadCount, 0);
        }

        [TestMethod]
        public void TestCategoryRepository()
        {
            //Arrange
            ICategoryRepository categoryRepository = new MockCategoryRepository();

            //Act
            int categoryCount = (categoryRepository.AllCategories as List<Category>).Count;

            //Assert
            Assert.AreNotEqual(categoryCount, 0);
        }
    }
}
