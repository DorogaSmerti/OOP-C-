using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        Order order = new Order { Id = 1, Status = OrderStatus.Pending };

        string json = JsonSerializer.Serialize(order);
        Console.WriteLine(json);

        Order deserializedOrder = JsonSerializer.Deserialize<Order>(json);
        Console.WriteLine($"Номер заказа: {deserializedOrder.Id}, Статус: {deserializedOrder.Status}");
    }
}
