
public class Program
{
    public static void Main(string[] args)
    {
        var taskManager = new Task1.TaskManager();
        taskManager.Load("tasks.json");

        while (true)
        {
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Изменить статус задачи");
            Console.WriteLine("3. Показать все задачи");
            Console.WriteLine("4. Сохранить и выйти");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите название задачи:");
                    var title = Console.ReadLine();
                    if (!string.IsNullOrEmpty(title))
                    {
                        taskManager.AddTask(title);
                    }
                    break;
                case "2":
                    Console.WriteLine("Введите индекс задачи для изменения статуса:");
                    if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < taskManager.tasks.Count)
                    {
                        taskManager.ChangeTaskStatus(index);
                    }
                    else
                    {
                        Console.WriteLine("Неверный индекс.");
                    }
                    break;
                case "3":
                    taskManager.ShowTasks();
                    break;
                case "4":
                    taskManager.Save("tasks.json");
                    return;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }
}
