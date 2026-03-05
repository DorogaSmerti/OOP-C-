public delegate double MathOperation(double a, double b);

public class MathOperations
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
            return 0;
        return a / b;
    }

    public static void Run(string[] args)
    {
        MathOperation mathOperation;
        mathOperation = MathOperations.Add;
        Console.WriteLine("Addition: " + mathOperation(5, 3));

        mathOperation = MathOperations.Subtract;
        Console.WriteLine("Subtraction: " + mathOperation(5, 3));

        mathOperation = MathOperations.Multiply;
        Console.WriteLine("Multiplication: " + mathOperation(5, 3));

        mathOperation = MathOperations.Divide;
        Console.WriteLine("Division: " + mathOperation(5, 3));
    }
}