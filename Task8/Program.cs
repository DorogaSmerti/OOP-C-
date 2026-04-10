using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        JsonDeserializerClass deserializer = new JsonDeserializerClass();
        TestClass test = new TestClass();

        test.Name = "John Doe";
        test.Age = 30;
        test.City = "New York";

        JsonSerializer.Serialize(test, new JsonSerializerOptions { WriteIndented = true });
        
        var result = deserializer.Deserialize<TestClass>("file.json");
        Console.WriteLine(result);
    }
}
