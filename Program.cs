
class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the path to the folder as an argument.");
            return;
        }

        string path = args[0];

        if (!Directory.Exists(path))
        {
            Console.WriteLine("Path does not exist.");
            return;
        }
        Console.WriteLine("reading file content");
        var reader = new StreamReaderClass();
        reader.StreamReader(Path.Combine(path, "asd.txt"));

        Console.WriteLine($"Analysis of directory: {path}");
        var inspector = new FileInspector();
        inspector.AnalyzeDirectory(path);

        Console.WriteLine("Search for the largest file");
        var finder = new FindBiggestFile();
        finder.FindLargestFile(path);

        if (args.Length > 1 && args[1] == "--clean")
        {
            Console.WriteLine(" Clean cache");
            var cleaner = new CleanCache();
            cleaner.ClearCacheSimple(path);
        }
    }
}