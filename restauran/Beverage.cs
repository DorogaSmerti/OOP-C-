using RestaurantApp;

public class Bevarage : MenuItem
{
    public double Volume{get;private set;}
    public bool Alcoholism{get;private set;}

    public Bevarage(int id, string name, decimal price, string description, double volume, bool alcoholism)
     : base(id, name, price, description)
    {
        Volume = volume;
        Alcoholism = alcoholism;
    }

    public override string GetDetails()
    {
        return $"Номер позиції: {Id}, Назва: {Name}, Ціна: {Price:C}, Опис: {Description}, Об'єм: {Volume}л, Алкогольний: {Alcoholism}";
    }
}