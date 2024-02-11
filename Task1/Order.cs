namespace Task1;
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    public string OrderID { get; set; } 
    public Customer Customer { get; set; }
    public Dictionary<Product, int> OrderedItems { get; set; }
    public int TotalAmount { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public DateTime OrderTime { get; set; }
    public void UpdateStatus(OrderStatus status)
    {
        status = OrderStatus;
    }
}
