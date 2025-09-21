namespace Task5;
public class Program
{
    public static double GetAverage(int[] marks)
    {
        double result = 0;
        foreach (int i in marks)
        {
            result += i;
        }
        return result / marks.Length;
    }
    public static int GetMin(int[] marks)
    {
        return marks.Min();
    }
    public static int GetMax(int[] marks)
    {
        return marks.Max();
    }
    public static void PrintGroupStatistics(int[][] groups)
    {
        for (int i = 0; i < groups.Length; i++)
        {
            int[] group = groups[i];
            double average = GetAverage(group);
            int min = GetMin(group);
            int max = GetMax(group);
            Console.WriteLine($"Група {i + 1}: Середній = {average}, Мінімальний = {min}, Максимальний = {max}");
        }
    }
     public static void Main()
    {
        
    }
}