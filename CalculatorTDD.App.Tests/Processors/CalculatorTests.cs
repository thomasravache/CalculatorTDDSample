using CalculatorTDD.App.Exceptions;
using CalculatorTDD.App.Interfaces.Processors;
using CalculatorTDD.App.Processors;

namespace CalculatorTDD.App.Tests.Processors;

public class CalculatorTests
{
    private readonly ICalculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    #region Method Sum

    [Theory(DisplayName = "Given Multiple Numbers When Sum Then Success")]
    [InlineData(new double[] { 5, 5 })]
    [InlineData(new double[] { 6, 4 })]
    [InlineData(new double[] { 2, 2, 2, 2, 2 })]
    [InlineData(new double[] { 3, 3, 3, 1 })]
    [InlineData(new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })]
    [InlineData(new double[] { 5, 5, -5, 5 })]
    [InlineData(new double[] { -10, 10, 10, 10, -10 })]
    public void Given_Multiple_Numbers_When_Sum_Then_Success(double[] sumArgs)
    {
        // Arrange
        double expectedResult = 10;

        // Act
        double result = _calculator.Sum(sumArgs);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    #endregion

    #region Method Subtract

    [Fact(DisplayName = "Given Numbers When Subtract Then Success")]
    public void Given_Numbers_When_Subtract_Then_Success()
    {
        // Arrange
        double expectedResult = 10;
        double number1 = 20;
        double number2 = 10;

        // Act
        double result = _calculator.Subtract(number1, number2);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    #endregion

    #region Method Divide

    [Fact(DisplayName = "Given Dividend And Divisor When Divide Then Success")]
    public void Given_Dividend_And_Divisor_When_Divide_Then_Success()
    {
        // Arrange
        double expectedResult = 10;
        double dividend = 20;
        double divisor = 2;

        // Act
        double result = _calculator.Divide(dividend, divisor);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact(DisplayName = "Given Zero Divisor When Divide Then Throw DivisionPerZeroException")]
    public void Given_Zero_Divisor_When_Divide_Then_Throw_DivisionPerZeroException()
    {
        // Arrange
        string expectedErrorMessage = "There is no division by zero.";
        double dividend = 10;
        double divisor = 0;

        // Act
        var exception = Assert.Throws<DivisionPerZeroException>(() => _calculator.Divide(dividend, divisor));

        // Assert
        Assert.Equal(expectedErrorMessage, exception.Message);
    }

    #endregion

    #region Method Multiplicate

    [Theory(DisplayName = "Given Multiple Positive Numbers When Multiplicate Then Success")]
    [InlineData(new double[] { 2, 5 })]
    [InlineData(new double[] { 5, 2 })]
    [InlineData(new double[] { 2, 2.5, 2 })]
    public void Given_Multiple_Positive_Numbers_When_Multiplicate_Then_Success(double[] multiplicateArgs)
    {
        // Arrange
        double expectedResult = 10;

        // Act
        double result = _calculator.Multiplicate(multiplicateArgs);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact(DisplayName = "Given Any Negative Number When Multiplicate Then Throw NegativeNumberNotAllowedException")]
    public void Given_Any_Negative_Number_When_Multiplicate_Then_Throw_NegativeNumberNotAllowedException()
    {
        // Arrange
        string expectedErrorMessage = "Negative numbers are not allowed.";
        double[] multiplicateArgs = new double[] { 2, -2.5, 2 };

        // Act
        var exception = Assert.Throws<NegativeNumberNotAllowedException>(() => _calculator.Multiplicate(multiplicateArgs));

        // Assert
        Assert.Equal(expectedErrorMessage, exception.Message);
    }

    #endregion
}