
namespace Task1;
public class TaskTracker
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public TaskTracker(string title)
    {
        Title = title;
        IsCompleted = false;
    }
    public TaskTracker() { }

    public override string ToString()
    {
        return $"{Title}, {IsCompleted}";
    }
}

