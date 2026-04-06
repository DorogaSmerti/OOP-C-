namespace Task1;
public class ProcessFileClass
{
    public static void ProcessFile(string inputPath, string outputPath, TextOperation operation)
    {
        if (!File.Exists(inputPath))
        {
            return;
        }

        string content = File.ReadAllText(inputPath);
        string result = operation(content);

        File.AppendAllText(outputPath, result + "\n---\n");
    }
}