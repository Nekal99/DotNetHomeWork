public class Order
{
    private readonly int orderId;
    private readonly User user;
    private readonly Product product;
    private readonly List<int> nums;


    public Order(int id, Product product, List<int> productnums, User user)
    {
        this.orderId = id;
        this.product = product;
        this.nums = productnums;
        this.user = user;
    }

    public Order(Order order)
    {
        this.orderId=order.orderId;
        this.product = order.product;
        this.nums = order.nums;
        this.user = order.user;
    }
    public int OrderId { get { return orderId;} }
    public User USer { get { return user; } }
    public Product Products { get { return product; } }
    public List<int> Nums { get { return nums; } }

    public int Equals(List<Order> orderList)
    {
        for (int i = 0; i < orderList.Count; i++)
        {
            if (orderList[i].orderId == this.orderId)
            {
                return i;
            }
        }
        return -1;
    }

    public new void ToString()
    {
        Console.WriteLine("订单号："+this.orderId);
        user.ToString();
        product.ToString();
        Console.WriteLine("产品名 数量");
        for (int i = 0;i< nums.Count; i++)
        {
            if (nums[i]!=0)
            {
                Console.WriteLine(product.ProductName[i] +" " + nums[i]);
            }
        }
    }
}

