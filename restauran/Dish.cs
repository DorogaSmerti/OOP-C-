namespace RestaurantApp;

public enum DishCategory
{
    ПершаСтрава,
    ДругаСтрава,
    Десерт
}
public class Dish : MenuItem
{
    public DishCategory Category{get;private set;}

    public Dish(DishCategory category, int id, string name, decimal price, string description) : base(id, name, price, description)
    {
        Category = category;
    }
    
    public override string GetDetails()
    {
       return $"Номер позиції: {Id}, Назва: {Name}, Ціна: {Price:C}, Опис: {Description}, Категорія: {Category}";
    }
}