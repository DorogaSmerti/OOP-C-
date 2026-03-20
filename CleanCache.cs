public class CleanCache
{
    public void ClearCacheSimple(string path)
{
    int deletedCount = 0;
    long totalDeletedSize = 0;

    var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

    foreach (var file in files)
    {
        var info = new FileInfo(file);
        totalDeletedSize += info.Length;
        
        File.Delete(file);
        deletedCount++;
    }

    Console.WriteLine($"Deleted files: {deletedCount}");
    Console.WriteLine($"Cleared space: {totalDeletedSize / 1024} KB");
}
}