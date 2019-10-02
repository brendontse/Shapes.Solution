using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class CircleTests
    {

        [TestMethod]
        public void Circle_GetArea_AreaOfCircle()
        {
            // Arrange
            Circle newCircle = new Circle(5);
            // Act
            double result = newCircle.GetArea();
            // Assert
            Assert.AreEqual(result, 78.5);
        }

        [TestMethod]
        public void Circle_GetCircumference_CircumferenceOfCircle()
        {
            // Arrange 
            Circle newCircle = new Circle(4);
            // Act 
            double result = newCircle.GetCircumference();
            // Assert
            Assert.AreEqual(result, 25.12);
        }
    }  

}