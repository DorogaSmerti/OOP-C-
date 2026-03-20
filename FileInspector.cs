public class FileInspector
{

public void AnalyzeDirectory(string path)
{
    DirectoryInfo dir = new DirectoryInfo(path);
    if (!dir.Exists) return;

    var folders = dir.GetDirectories();
    var allFiles = dir.GetFiles("*.*", SearchOption.AllDirectories);

    Console.WriteLine($"Folders: {folders.Length}");
    Console.WriteLine($"Files: {allFiles.Length}");
    
    long totalSize = allFiles.Sum(f => f.Length);
    Console.WriteLine($"Total size: {totalSize / (1024 * 1024)} MB");

    var largest = allFiles.OrderByDescending(f => f.Length).FirstOrDefault();
    if (largest != null)
    {
        Console.WriteLine($"Largest file: {largest.Name} ({largest.Length / 1024} KB)");
    }
}
}