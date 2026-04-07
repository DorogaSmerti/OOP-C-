
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student("Alice", 20, 85.5),
            new Student("Bob", 22, 90.0),
            new Student("Charlie", 19, 78.0),
            new Student("David", 21, 92.5),
            new Student("Eve", 20, 88.0)
        };

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(students, options);
        File.WriteAllText("students.json", jsonString);

        string jsonFromFile = File.ReadAllText("students.json");
        List<Student> deserializedStudents = JsonSerializer.Deserialize<List<Student>>(jsonFromFile);
        foreach (var student in deserializedStudents)
        {
            Console.WriteLine(student.ToString());
        }
    }
}
