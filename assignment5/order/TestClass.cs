using System;

/// <summary>
/// Summary description for TestClass
/// </summary>
public class TestClass
{
    public static void Main()
    {
        List<string> _productName = new List<string>() { "1", "2", "3", "4" };
        List<double> _price = new List<double> { 1, 1.5, 2, 2.5 };
        Product product = new Product(_productName, _price);
        User user = new User("Nekal");
        List<int> num1 = new List<int>() { 0, 2, 0, 1 };
        List<int> num2 = new List<int>() { 5, 2, 0, 1 };
        List<int> num3 = new List<int>() { 0, 2, 6, 1 };
        List<int> num4 = new List<int>() { 9, 2, 7, 1 };
        Order order1 = new Order(1, product, num1, user);
        Order order2 = new Order(2, product, num2, user);
        Order order3 = new Order(3, product, num3, user);
        Order order4 = new Order(4, product, num4, user);
        OrderService orderList = new OrderService(order1);
        orderList.AddOrder(order4);
        orderList.AddOrder(order2);
        orderList.AddOrder(order3);
        orderList.Sort();
        orderList.DeleteOrder(order3);
        Order order5 = new(orderList.GetOrder(2));
        order5.ToString();
        Console.WriteLine("总价格：");
        double total = orderList.GetTotalMoney(4);
        Console.WriteLine(total);
        string address = "Wuhan University";
        string description = "Thank You";
        OrderDetails orderDetails = new OrderDetails(order1, address, description);
        order1.ToString();
        orderDetails.ToString();
        Order order6 = new Order(1, product, num2, user);
        orderList.UpdateOrder(order6);
        order6.ToString();
    }
}
