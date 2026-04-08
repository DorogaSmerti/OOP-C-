using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        string jsonFromFile = File.ReadAllText("player.json");
        Player deserializedPlayer = JsonSerializer.Deserialize<Player>(jsonFromFile);

        Console.WriteLine($"Имя: {deserializedPlayer.Name}");
        Console.WriteLine($"Инвентарь: {string.Join(", ", deserializedPlayer.Inventory.Items)}");

    }
}
