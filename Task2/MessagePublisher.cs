namespace Task2;
public class MessagePublisher
{
    public event Action<string> OnMessageSent;

    public void Send(string message)
    {
        OnMessageSent?.Invoke(message);
    }
}