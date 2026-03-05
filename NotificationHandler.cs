public delegate void NotificationHandler(string message);

public class NotificationHandles()
{
    public static void SendEmail(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }

    public static void SendSms(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }

    public static void Run(string[] args)
    {
        NotificationHandler notificationHandles;
        notificationHandles = SendEmail;
        notificationHandles += SendSms;
        notificationHandles("OOO");
    }
}