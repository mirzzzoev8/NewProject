namespace Task1;
public class ShoppingCart
{
    Dictionary<Product,int> CartItems { get; set; }
   
    public void AddToCart(Product product, int quantity)
    {
        CartItems?.Add(product,quantity);
    }
    public Dictionary<Product,int> GetCartItem()
    {
        return CartItems;
    }
}
