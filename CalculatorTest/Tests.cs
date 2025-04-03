public class CalculatorTests
{
    //Проверки метода Add (Сложение)
    
    [Test]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        double a = 5;
        double b = 3;
        double result = Calculator.Add(a, b);
        Assert.AreEqual(8, result);
    }
    
    

    [Test]
    public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
    {
        double a = -5;
        double b = -3;
        double result = Calculator.Add(a, b);
        Assert.AreEqual(-8, result);
    }

    [Test]
    public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
    {
        double a = 5;
        double b = -3;
        double result = Calculator.Add(a, b);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Add_ZeroAndNumber_ReturnsSameNumber()
    {
        double a = 0;
        double b = 7;
        double result = Calculator.Add(a, b);
        Assert.AreEqual(7, result);
    }
    
    [Test]
    public void Add_WithMaxDoubleValue_ReturnsInfinity()
    {
        double a = double.MaxValue;
        double b = double.MaxValue;
        double result = Calculator.Add(a, b);
        Assert.IsTrue(double.IsInfinity(result));
    }
    
    
    
    ////Проверки метода Subtract (Вычитание)
    
    
    [Test]
    public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        double a = 5;
        double b = 3;

        // Act
        double result = Calculator.Subtract(a, b);

        // Assert
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Subtract_TwoNegativeNumbers_ReturnsCorrectDifference()
    {
        double a = -5;
        double b = -3;
        double result = Calculator.Subtract(a, b);
        Assert.AreEqual(-2, result);
    }

    [Test]
    public void Subtract_PositiveAndNegativeNumber_ReturnsCorrectDifference()
    {
        double a = 5;
        double b = -3;
        double result = Calculator.Subtract(a, b);
        Assert.AreEqual(8, result);
    }
    
    [Test]
    public void Subtract_DecimalNumbers_ReturnsCorrectDifference()
    {
        double a = 5.5;
        double b = 3.2;
        double result = Calculator.Subtract(a, b);
        Assert.AreEqual(2.3, result, 0.0001);
    }
    
    
    ////Проверки метода Multiply (Умножение)
    
    [Test]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
    {
        double a = 5;
        double b = 3;
        double result = Calculator.Multiply(a, b);
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Multiply_TwoNegativeNumbers_ReturnsCorrectProduct()
    {
        double a = -5;
        double b = -3;
        double result = Calculator.Multiply(a, b);
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Multiply_PositiveAndNegativeNumber_ReturnsCorrectProduct()
    {
        double a = 5;
        double b = -3;
        double result = Calculator.Multiply(a, b);
        Assert.AreEqual(-15, result);
    }

    [Test]
    public void Multiply_ByZero_ReturnsZero()
    {
        double a = 5;
        double b = 0;
        double result = Calculator.Multiply(a, b);
        Assert.AreEqual(0, result);
    }
    
    [Test]
    public void Multiply_DecimalNumbers_ReturnsCorrectProduct()
    {
        double a = 2.5;
        double b = 1.5;
        double result = Calculator.Multiply(a, b);
        Assert.AreEqual(3.75, result, 0.0001);
    }
    
    [Test]
    public void Multiply_WithVerySmallNumbers_ReturnsCorrectResult()
    {
        double a = 1E-300;
        double b = 1E-300;
        double result = Calculator.Multiply(a, b);
        Assert.AreEqual(1E-600, result, 1E-615);
    }
    
    
    
    //Проверки метода Divide (Деление)
    
    [Test]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
    {
        double a = 6;
        double b = 3;
        double result = Calculator.Divide(a, b);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Divide_TwoNegativeNumbers_ReturnsCorrectQuotient()
    {
        double a = -6;
        double b = -3;
        double result = Calculator.Divide(a, b);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Divide_PositiveByNegativeNumber_ReturnsCorrectQuotient()
    {
        double a = 6;
        double b = -3;
        double result = Calculator.Divide(a, b);
        Assert.AreEqual(-2, result);
    }

    [Test]
    public void Divide_ByOne_ReturnsSameNumber()
    {
        double a = 5;
        double b = 1;
        double result = Calculator.Divide(a, b);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        double a = 5;
        double b = 0;
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }

    [Test]
    public void Divide_ZeroByNumber_ReturnsZero()
    {
        double a = 0;
        double b = 5;
        double result = Calculator.Divide(a, b);
        Assert.AreEqual(0, result);
    }
    
    [Test]
    public void Divide_DecimalNumbers_ReturnsCorrectQuotient()
    {
        double a = 5.5;
        double b = 2.0;
        double result = Calculator.Divide(a, b);
        Assert.AreEqual(2.75, result, 0.0001);
    }
    
    
    //Проверки метода Power (Возведение в степень)

    [Test]
    public void Power_PositiveNumberToPositivePower_ReturnsCorrectResult()
    {
        double a = 2;
        double b = 3;
        double result = Calculator.Power(a, b);
        Assert.AreEqual(8, result);
    }

    [Test]
    public void Power_PositiveNumberToZeroPower_ReturnsOne()
    {
        double a = 5;
        double b = 0;
        double result = Calculator.Power(a, b);
        Assert.AreEqual(1, result);
    }

    [Test]
    public void Power_ZeroToPositivePower_ReturnsZero()
    {
        double a = 0;
        double b = 5;
        double result = Calculator.Power(a, b);
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Power_NegativeNumberToEvenPower_ReturnsPositiveResult()
    {
        double a = -2;
        double b = 4;
        double result = Calculator.Power(a, b);
        Assert.AreEqual(16, result);
    }

    [Test]
    public void Power_NegativeNumberToOddPower_ReturnsNegativeResult()
    {
        double a = -2;
        double b = 3;
        double result = Calculator.Power(a, b);
        Assert.AreEqual(-8, result);
    }

    [Test]
    public void Power_ZeroToZeroPower_ThrowsException()
    {
        double a = 0;
        double b = 0;
        Assert.Throws<ArgumentException>(() => Calculator.Power(a, b));
    }
    
    
    [Test]
    public void Power_DecimalExponent_ReturnsCorrectResult()
    {
        double a = 4;
        double b = 0.5;
        double result = Calculator.Power(a, b);
        Assert.AreEqual(2, result, 0.0001);
    }
    
    
    [Test]
    public void Power_WithFractionalBaseAndExponent_ReturnsCorrectResult()
    {
        double a = 2.5;
        double b = 1.5;
        double result = Calculator.Power(a, b);
        Assert.AreEqual(Math.Pow(2.5, 1.5), result, 0.0001);
    }

    
    
    //Проверки метода Factorial (Факториал)
    
    

    [Test]
    public void Factorial_PositiveNumber_ReturnsCorrectResult()
    {
        int n = 5;
        double result = Calculator.Factorial(n);
        Assert.AreEqual(120, result);
    }

    [Test]
    public void Factorial_Zero_ReturnsOne()
    {
        int n = 0;
        double result = Calculator.Factorial(n);
        Assert.AreEqual(1, result);
    }

    [Test]
    public void Factorial_One_ReturnsOne()
    {
        int n = 1;
        double result = Calculator.Factorial(n);
        Assert.AreEqual(1, result);
    }

    [Test]
    public void Factorial_NegativeNumber_ThrowsException()
    {
        int n = -5;
        Assert.Throws<ArgumentException>(() => Calculator.Factorial(n));
    }
    
    [Test]
    public void Factorial_OfDecimal_ThrowsException()
    {
        double n = 5.5;
        Assert.Throws<ArgumentException>(() => Calculator.Factorial(n));
    }
    
    
    [Test]
    public void Factorial_OfLargeNumber_ReturnsInfinity()
    {
        int n = 200;
        double result = Calculator.Factorial(n);
        Assert.IsTrue(double.IsInfinity(result));
    }
    
    
    
    //Проверки метода Sqrt (Нахождения корня)
    

    [Test]
    public void Sqrt_PositiveNumber_ReturnsCorrectResult()
    {
        double a = 16;
        double result = Calculator.Sqrt(a);
        Assert.AreEqual(4, result);
    }

    [Test]
    public void Sqrt_Zero_ReturnsZero()
    {
        double a = 0;
        double result = Calculator.Sqrt(a);
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Sqrt_NegativeNumber_ThrowsException()
    {
        double a = -16;
        Assert.Throws<ArgumentException>(() => Calculator.Sqrt(a));
    }

    [Test]
    public void Sqrt_FractionalNumber_ReturnsCorrectResult()
    {
        double a = 2.25;
        double result = Calculator.Sqrt(a);
        Assert.AreEqual(1.5, result);
    }
    
    
    [Test]
    public void Sqrt_DecimalNumber_ReturnsCorrectResult()
    {
        double a = 6.25;
        double result = Calculator.Sqrt(a);
        Assert.AreEqual(2.5, result, 0.0001);
    }

   
    
    
    
    
    //Проверка парсинга вводимых данных
    

    [Test]
    public void ParseInput_WithNonNumeric_ThrowsException()
    {
        string input = "abc";
        Assert.Throws<FormatException>(() => Convert.ToDouble(input));
    }

    [Test]
    public void ParseInput_WithVeryLargeNumber_ThrowsException()
    {
        string input = "1E+400";
        Assert.Throws<OverflowException>(() => Convert.ToDouble(input));
    }


    [Test]
    public void ParseInput_WithCommaAsDecimalSeparator_WorksCorrectly()
    {
        string input = "3,14";
        double result = Convert.ToDouble(input);
        Assert.AreEqual(3.14, result, 0.0001);
    }
    
}
    
    
