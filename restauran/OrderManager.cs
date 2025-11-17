using RestaurantApp;

public class OrderManager
{
    private readonly List<Order> _orders = new();
    private int _nextOrderId = 1;

    public Order CreateNewOrder(int tableNumber)
    {   
        var newOrder = new Order (_nextOrderId, tableNumber);
        _orders.Add(newOrder);
        _nextOrderId++;
        return newOrder;
    }

    public Order FindOrderById(int id)
    {
        return _orders.FirstOrDefault(p => p.Id == id);
    }

    public bool ChangeStatus(int id, OrderStatus orderStatus)
    {
        var order = _orders.FirstOrDefault(p => p.Id == id);

        if(order == null)
        {
           return false; 
        }

        order.ChangeOrderStatus(orderStatus);
        return true;
    }

    public string DisplayActiveOrder()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("--- ВСІ ЗАМОВЛЕННЯ ---");

        foreach(var order in _orders)
        {
            sb.AppendLine(order.DisplaySummary());
        }
        sb.AppendLine("---------------------");

        return sb.ToString();
    }
}