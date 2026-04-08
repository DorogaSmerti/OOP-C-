public class Player
{
    public string Name{get;set;}
    private Inventory _inventory { get; set; }
    public Inventory Inventory
    {
        get => _inventory ??= new Inventory();
        set => _inventory = value;
    }

    public Player()
    {
        _inventory = new Inventory("Меч", "Щит", "Зелье");
    }
}

public class Inventory
{
    public List<string> Items { get; set; }

    public Inventory(params string[] items)
    {
        Items = new List<string>(items);
    }
}