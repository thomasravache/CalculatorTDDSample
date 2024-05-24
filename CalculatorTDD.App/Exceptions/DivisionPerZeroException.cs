namespace CalculatorTDD.App.Exceptions;

public class DivisionPerZeroException : Exception
{
    public DivisionPerZeroException(string message) : base(message)
    {
        
    }
}