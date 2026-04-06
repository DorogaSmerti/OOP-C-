namespace Task2;
public class FileLogger
{
    private string FileName = "logPD25.txt";

    public void Register(MessagePublisher publisher)
    {
        publisher.OnMessageSent += LogToFile;
    }

    private void LogToFile(string message)
    {
        string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 
            
        File.AppendAllText(FileName, $"{time}: {message}\n");
    }
}