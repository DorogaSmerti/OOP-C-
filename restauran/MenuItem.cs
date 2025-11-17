namespace RestaurantApp;

public abstract class MenuItem
{
    public int Id{get;set;}
    public string Name{get;set;}
    public decimal Price{get;set;}
    public string Description{get;set;}

    public MenuItem(int id, string name, decimal price, string description)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = description;
    }

    public abstract string GetDetails();

    public override string ToString()
    {
        return $"{Name} - {Price:C} | {Description}";
    }
}