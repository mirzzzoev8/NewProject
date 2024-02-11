namespace Task1;
public class EcommerceSystem : Order
{
    List<Product> products;
    List<Customer> customers;
    List<Order> orders;
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void Addcustomer(Customer customer)
    {
        customers.Add(customer);
    }
    public void PlaceOrder(Customer customer, ShoppingCart cart)
    {
        var order = new Order();
        OrderID = Guid.NewGuid().ToString();
        order.Customer = customer;
        order.OrderedItems = cart.GetCartItem();
        int total = 0;
        order.TotalAmount = total;
        order.OrderStatus = OrderStatus.Placed;
        order.OrderTime = DateTime.UtcNow;
        orders.Add(order);
    }
    public void UpdateOrderStatus(string orderId, OrderStatus status)
    {
        var found = orders.FirstOrDefault(e => e.OrderID == orderId);
        if (found != null)
        {
            found.OrderStatus = status;
        }
    }
    public void DisplayAllOrders()
    {
        foreach (var item in orders)
        {
            System.Console.WriteLine("OrderId = " + item.OrderID);
            System.Console.WriteLine("OrderStatus = " + item.OrderStatus);
            System.Console.WriteLine("OrderTime = " + item.OrderTime);
            System.Console.WriteLine("Customer = " + item.Customer);
            foreach (var ite in OrderedItems)
            {
                System.Console.WriteLine(ite.Key.Name);
                System.Console.WriteLine("Value = " + ite.Value);
            }
            System.Console.WriteLine("TotalAmount = " + item.TotalAmount);
        }
    }

}
