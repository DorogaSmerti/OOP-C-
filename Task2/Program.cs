using System.Data;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Task2;
public class Program
{
    public static int[] GenerateRandomArray(int size, int min, int max)
    {
        int[] numbers = new int[size];
        Random random = new Random();


        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(min, max + 1);
        }
        return numbers;
    }
    public static int GetSum(int[] numbers)
    {
        int result = 0;
        foreach (int i in numbers)
        {
            result += i;
        }
        return result;
    }
    public static double GetAverage(int[] numbers)
    {
        double result = 0;
        foreach (int i in numbers)
        {
            result += i;
        }
        return result / numbers.Length;
    }
    public static int GetMin(int[] numbers)
    {
        return numbers.Min();
    }
    public static int GetMax(int[] numbers)
    {
        return numbers.Max();
    }
    public static void Main()
    {

    }
}