
namespace Task4;
public class Program
{
    public static bool IsValidTriangle(double a, double b, double c)
    {
        return a > 0 && b > 0 && c > 0 &&
        a + b > c &&
        a + c > b &&
        b + c > a;
    }
    public static double GetPerimeter(double a, double b, double c)
    {
        if (!IsValidTriangle(a, b, c))
            throw new ArgumentException("Некоректний трикутник");
        return a + b + c;
    }
    public static double GetArea(double a, double b, double c)
    {
        if (!IsValidTriangle(a, b, c))
            throw new ArgumentException("Некоректний трикутник");
        return GetPerimeter(a, b, c) / 2;
    }
    public static string GetTriangleType(double a, double b, double c)
    {
        if (!IsValidTriangle(a, b, c))
            throw new ArgumentException("Некоректний трикутник");

        if (a == b && b == c)
            return "рівносторонній";
        if (a == b || a == c || b == c)
            return "рівнобедрений";
        if (a * a + b * b == c * c ||
            a * a + c * c == b * b ||
            b * b + c * c == a * a)
            return "прямокутний";

        if (a == b || a == c || b == c)
            return "рівнобедрений";

        return "довільний";
    }
     public static void Main()
    {
        
    }
}