namespace RestaurantApp;

public enum OrderStatus
{
    Очікується,
    Готується,
    Завершено,
    Відмінено
}

public class Order
{
    public int Id{get;private set;}
    public int TableNumber{get;private set;}
    public OrderStatus Status{get;private set;}
    public List<MenuItem> Items{get;} = new();
    public DateTime OrderTime{get;private set;}

    public Order(int id, int tableNumber)
    {
        Id = id;
        TableNumber = tableNumber;
        Status = OrderStatus.Очікується;
        Items = new List<MenuItem>();
        OrderTime = DateTime.Now;
    }

    public void AddItemInOrder(MenuItem menuItem)
    {
        Items.Add(menuItem);
    }

    public bool RemoveItemFromOrder(MenuItem items)
    {
        return Items.Remove(items);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalSum = 0;
        foreach(var i in Items)
        {
            totalSum += i.Price;
        }
        return totalSum;
    }

    public void ChangeOrderStatus(OrderStatus orderStatus)
    {
        Status = orderStatus;
    }

    public string DisplaySummary()
    {
        var sb = new System.Text.StringBuilder();
        decimal total = CalculateTotalCost();

        sb.AppendLine($"--- ЗАМОВЛЕННЯ ID: {Id} ---");
        sb.AppendLine($"Стіл: {TableNumber} | Статус: {Status} | Час: {OrderTime:HH:mm:ss}");
        sb.AppendLine($"Загальна сума: {total:C}");

        sb.AppendLine("--- Позиції ---");
    
    if (Items.Any())
    {   
        int count = 1;
        
        foreach (var item in Items)
        {

            sb.AppendLine($"  {count}. {item.ToString()}"); 
            count++;
        }
    }
    else
    {
        sb.AppendLine("  *Замовлення поки що не містить позицій.*");
    }
    
    sb.AppendLine("------------------");

    return sb.ToString();
    }
}