using System.Text.Json;

namespace Task1;
public class TaskManager
{
    public List<TaskTracker> tasks = new();

    public void Save(string path)
    {
        var option = new JsonSerializerOptions{WriteIndented = true};
        var content = JsonSerializer.Serialize(tasks, option);
        File.WriteAllText(path, content);
    }

    public void Load(string path)
    {
        if(!File.Exists(path)) return;

        var content = File.ReadAllText(path);
        tasks = JsonSerializer.Deserialize<List<TaskTracker>>(content) ?? new();
    }

    public void AddTask(string title)
    {
        tasks.Add(new TaskTracker(title));
    }

    public void ChangeTaskStatus(int index)
    {
        ShowTasks();
        tasks[index].IsCompleted = !tasks[index].IsCompleted;
        Console.WriteLine($"Статус задачи змiненно {tasks[index].IsCompleted}");
    }

    public void ShowTasks()
    {
        for(int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i].ToString()}");
        }
        Console.WriteLine("------------------------------");
    }
}