using CalculatorTDD.App.Exceptions;
using CalculatorTDD.App.Interfaces.Processors;

namespace CalculatorTDD.App.Processors;

public class Calculator : ICalculator
{
    public double Divide(double dividend, double divisor)
    {
        if (divisor.Equals(0))
            throw new DivisionPerZeroException("There is no division by zero.");

        return dividend / divisor;
    }

    public double Multiplicate(double[] args)
    {
        ValidateMultiplicate(args);

        double result = 1;

        foreach (var arg in args) result *= arg;

        return result;
    }

    private void ValidateMultiplicate(double[] args)
    {
        bool anyIsNegative = args
            .ToList()
            .Exists(arg => arg < 0);

        if (anyIsNegative)
            throw new NegativeNumberNotAllowedException("Negative numbers are not allowed.");
    }

    public double Subtract(double number1, double number2)
    {
        return number1 - number2;
    }

    public double Sum(double[] args)
    {
        return args.Sum();
    }
}