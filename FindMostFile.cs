public class FindBiggestFile
{
    public void FindLargestFile(string path)
{
    DirectoryInfo dir = new DirectoryInfo(path);
    var largest = dir.GetFiles("*.*", SearchOption.AllDirectories)
                     .OrderByDescending(f => f.Length)
                     .FirstOrDefault();

    if (largest != null)
    {
        Console.WriteLine($"Name: {largest.Name}");
        Console.WriteLine($"Size: {largest.Length} bytes");
        Console.WriteLine($"Path: {largest.FullName}");
    }
}}