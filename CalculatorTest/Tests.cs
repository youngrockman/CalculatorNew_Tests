using NUnit.Framework;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            double a = 5;
            double b = 3;
            
            // Act
            double result = Calculator.Add(a, b);
            
            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
        {
            Assert.AreEqual(2, Calculator.Add(5, -3));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(2, Calculator.Add(-5, -3));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            Assert.AreEqual(2, Calculator.Subtract(5, 3));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            Assert.AreEqual(15, Calculator.Multiply(5, 3));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(2, Calculator.Divide(6, 3));
        }

        [Test]
        public void Divide_TwonNegativeNumbers_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(3, Calculator.Divide(-1, -3));
        }
        
        

        [Test]
        public void Divide_ByZero_ShouldReturnInfinity()
        {
            double number = 5;
            double zero = 0;
            double result = Calculator.Divide(number, zero);
            bool isInfinity = double.IsPositiveInfinity(result);
            Assert.IsTrue(isInfinity, "Деление на ноль должно давать бесконечность");
        }

        [Test]
        public void Power_NumberToPower_ReturnsCorrectValue()
        {
            Assert.AreEqual(8, Calculator.Power(2, 3));
        }

        [Test]
        public void Power_WithTwoNegativeNumbers_ReturnsCorrectPower()
        {
            Assert.AreEqual(-1, Calculator.Power(-1, -3));
        }

        [Test]
        public void Power_WithNegativeNumber_ReturnsCorrectPower()
        {
            Assert.AreEqual(0.008, Calculator.Power(5, -3), 0.0001);
        }


        [Test]
        public void Sqrt_Number_ReturnsCorrectSquareRoot()
        {
            Assert.AreEqual(3, Calculator.Sqrt(9));
        }

        [Test]
        public void Sqrt_NegativeNumber_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sqrt(-1));
        }


        [Test]
        public void Factorial_PositiveNumber_ReturnsCorrectValue()
        {
            Assert.AreEqual(120, Calculator.Factorial(5));
        }

        [Test]
        public void Factorial_Zero_ReturnsOne()
        {
            Assert.AreEqual(1, Calculator.Factorial(0));
        }

        [Test]
        public void Factorial_NegativeNumber_ReturnsOne()
        {
            Assert.AreEqual(1, Calculator.Factorial(-5));
        }
    }
}