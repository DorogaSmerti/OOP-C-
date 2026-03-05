using System;
using System.Collections.Generic;

public class MathOperationsRefactor
{
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b) => b == 0 ? 0 : a / b;

    public static void Run(string[] args)
    {
        Func<double, double, double> mathOperation;

        mathOperation = Add;
        Console.WriteLine("Addition: " + mathOperation(5, 3));

        mathOperation = Subtract;
        Console.WriteLine("Subtraction: " + mathOperation(5, 3));

        mathOperation = Multiply;
        Console.WriteLine("Multiplication: " + mathOperation(5, 3));

        mathOperation = Divide;
        Console.WriteLine("Division: " + mathOperation(5, 3));
        
        FilterStudents();
    }

    public static void FilterStudents()
    {
        List<string> students = new List<string> 
        { 
            "Олексій", "Марія", "Олена",
        };

        char searchLetter = 'О';

        List<string> result = students.FindAll(s => s.StartsWith(searchLetter));

        Console.WriteLine($"Імена, що починаються на '{searchLetter}':");
        result.ForEach(name => Console.WriteLine(name));
    }
}