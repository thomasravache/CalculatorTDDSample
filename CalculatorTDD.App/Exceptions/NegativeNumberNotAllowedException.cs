namespace CalculatorTDD.App.Exceptions;

public class NegativeNumberNotAllowedException : Exception
{
    public NegativeNumberNotAllowedException(string message) : base(message)
    {
        
    }
}