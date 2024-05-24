namespace CalculatorTDD.App.Interfaces.Processors;

public interface ICalculator
{
    double Sum(double[] args);
    double Subtract(double number1, double number2);
    double Divide(double dividend, double divisor);
    double Multiplicate(double[] args);
}