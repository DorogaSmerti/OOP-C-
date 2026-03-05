using System;

public class Logger
{
    public Action<string> LogHandler;

    public void Log(string message)
    {
        LogHandler?.Invoke(message);
    }
}

class LoggerExample
{
    public static void Run()
    {
        Logger myLogger = new Logger();

        myLogger.LogHandler = msg => Console.WriteLine($"Log: {msg}");
        myLogger.Log("Program started");

        myLogger.LogHandler = msg => Console.WriteLine($"Log: {msg.ToUpper()}");
        myLogger.Log("important message");
    }
}