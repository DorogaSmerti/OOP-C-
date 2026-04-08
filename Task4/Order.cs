using System.Text.Json.Serialization;

public class Order
{
    public int Id{get;set;}

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public OrderStatus Status { get; set; }
}