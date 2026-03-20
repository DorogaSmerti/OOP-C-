public class StreamReaderClass
{
    public void StreamReader(string path)
    {
        int lines = 0;
        int words = 0;
        int characters = 0;

        foreach (var line in File.ReadLines(path))
        {
            lines++;
            words += line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            characters += line.Count(c => !char.IsWhiteSpace(c));
        }

        File.WriteAllText("report.txt", $"Lines: {lines}\nWords: {words}\nCharacters: {characters}");
}}