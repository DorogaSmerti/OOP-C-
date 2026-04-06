using Task2;
using Task1;

public class Program
{
    public static void Main(string[] args)
    {
        string inputPath = "textPD25.txt";
        string outputPath = "resultPD25.txt";
        MessagePublisher publisher = new MessagePublisher();
        FileLogger logger = new FileLogger();

        File.WriteAllText(outputPath, string.Empty);

        ProcessFileClass.ProcessFile(inputPath, outputPath, TextOperations.ToUpper);
        ProcessFileClass.ProcessFile(inputPath, outputPath, TextOperations.CountChar);
        ProcessFileClass.ProcessFile(inputPath, outputPath, TextOperations.CountWord);

        logger.Register(publisher);

        Console.WriteLine("Введіть текст 4 рази:");

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{i + 1}: ");
            string input = Console.ReadLine();
            publisher.Send(input);
        }
    }
}
