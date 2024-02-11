using Task1;
using System.ComponentModel.DataAnnotations;
var traSystem = new EcommerceSystem();

var product1 = new Product();
product1.ProductId = "1";
product1.Name = "RC-Cola";
product1.Price = 10;
traSystem.AddProduct(product1);

var product2 = new Product();
product2.ProductId = "2";
product2.Name = "Cola";
product2.Price = 5;
traSystem.AddProduct(product2);


var customer1 = new Customer();
customer1.CustomerId = "122";
customer1.Name = "Yusuf";

var customer2 = new Customer();
customer2.CustomerId = "123";
customer2.Name = "Yusufjon";


var shoppingcart1 = new ShoppingCart();
shoppingcart1.AddToCart(product1,1);
traSystem.PlaceOrder(customer1,shoppingcart1);
traSystem.DisplayAllOrders();

var shoppingcart2 = new ShoppingCart();
shoppingcart2.AddToCart(product2,2);
traSystem.PlaceOrder(customer2,shoppingcart2);
traSystem.DisplayAllOrders();


var order = new Order();
order.OrderID = "1";
order.TotalAmount = 1;


var ecommercesystem = new EcommerceSystem();
ecommercesystem.AddProduct(product1);
ecommercesystem.AddProduct(product2);
ecommercesystem.Addcustomer(customer1);
ecommercesystem.Addcustomer(customer2);


ecommercesystem.DisplayAllOrders();
