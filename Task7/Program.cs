using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player("Джон");

        string json = JsonSerializer.Serialize(player);
        File.WriteAllText("player.json", json);

        string jsonFromFile = File.ReadAllText("player.json");
        NewPlayer deserializedPlayer = JsonSerializer.Deserialize<NewPlayer>(jsonFromFile);

        Console.WriteLine($"Имя: {deserializedPlayer.Name}, Уровень: {deserializedPlayer.Level}");
    }
}
