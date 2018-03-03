using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringCalculator;

namespace StringCalculator.tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Test_Empty_String()
        {
            //Arrange
            string numbers = string.Empty;
            var additionCalculator = new AdditionCalculator();

            //Act
            int result = additionCalculator.AddNumbers("");

            //Assert
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void Test_For_1_Number_Returns_That_Number_Plus_Zero()
        {
            //Arrange
            var additionCalculator = new AdditionCalculator();

            //Act
            int result = additionCalculator.AddNumbers("1");

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
