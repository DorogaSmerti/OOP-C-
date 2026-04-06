namespace Task1;

public delegate string TextOperation(string input);

public class TextOperations
{
    public static string ToUpper(string input) => input.ToUpper();

    public static string CountChar(string input) => $"Кiлькiсть символiв: {input.Length}";

    public static string CountWord(string input)
    {
        int count = input.Split(" ").Length;
        return $"Кiлькiсть cлiв: {count}";
    }
}