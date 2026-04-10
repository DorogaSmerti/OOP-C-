using System.Text.Json;

public class JsonDeserializerClass
{
    public T Deserialize<T>(string path) where T : new()
    {
        try
        {
            T result = JsonSerializer.Deserialize<T>(File.ReadAllText(path));
            if (result == null)
            {
                Console.WriteLine("Deserialization resulted in null. Returning default value.");
                return new T();
            }
            return result;

        } catch (JsonException ex)
        {
            Console.WriteLine($"Error deserializing JSON: {ex.Message}");
            return new T();
        }
    }
}