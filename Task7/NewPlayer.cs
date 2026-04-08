public class NewPlayer
{
    public string Name { get; set; }
    public int Level { get; set; } = 1;

    public NewPlayer(string name, int level)
    {
        Name = name;
        Level = level;
    }
    public NewPlayer() { }
}