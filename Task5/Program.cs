using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog { Name = "Дружок", BarkVolume = 5 },
            new Cat { Name = "КIт", Lives = 9 }
        };

        var json = JsonSerializer.Serialize(animals);

        var deserializedAnimals = JsonSerializer.Deserialize<List<Animal>>(json);

        foreach (var animal in deserializedAnimals)
        {
            Console.WriteLine($"Имя: {animal.Name}");
            if (animal is Dog dog)
            {
                Console.WriteLine($"Громкость лая: {dog.BarkVolume}");
            }
            else if (animal is Cat cat)
            {
                Console.WriteLine($"Оставшиеся жизни: {cat.Lives}");
            }
        }
    }
}
