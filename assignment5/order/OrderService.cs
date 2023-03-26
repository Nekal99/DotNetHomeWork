using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Summary description for OrderService
/// </summary>
public class OrderService
{
	private List<Order> orderList;
	public OrderService(Order order)
	{
        this.orderList = new List<Order>
        {
            order
        };
    }

	public bool AddOrder(Order order)
	{
        int index = order.Equals(this.orderList);
        if (index == -1)
		{
			orderList.Add(order);
			return true;
		}
		return false;
	}

    public void DeleteOrder(Order order)
    {
        try
        {
            int index = order.Equals(this.orderList);
            if (index != -1)
            {
                orderList.RemoveAt(index);
            }
        }
        catch {
            throw new Exception("delete fail");
        }
    }

    public void UpdateOrder(Order order)
	{
        try
        {
            int index = order.Equals(this.orderList);
            if (index == -1)
            {
                orderList.Add(order);
            }
            else
            {
                orderList.RemoveAt(index);
                orderList.Add(order);
            }
        }
        catch 
        {
            throw new Exception("update fail");
        }
    }

    public Order GetOrder(int id)
    {

        var result = from s in orderList
                     where s.OrderId == id
                     select s;
        if (result != null)
        {
            foreach (var item in result)
            {
                if (item != null)
                {
                    Order order = new Order(item.OrderId, item.Products, item.Nums, item.USer);
                    return order;
                }
                throw new Exception("get fail");
            }
        }
        throw new Exception("get fail");
    }

    public double GetTotalMoney(int id)
    {
        var index = from s in orderList
                    where s.OrderId == id
                    select s;
        double total = 0;
        if (index != null)
        {
            foreach (var item in index)
            {
                if (item != null)
                {
                    Order order = new Order(item.OrderId, item.Products, item.Nums, item.USer);
                    for (int i = 0; i < order.Nums.Count; i++)
                    {
                        if (order.Nums[i] != 0)
                        {
                            total += order.Nums[i] * order.Products.Prices[i];
                        }
                    }
                    return total;
                }
                throw new Exception("total fail");
            }
        }
        throw new Exception("total fail");
    }

    public void Sort()
    {
        Comparison<Order> byOrderId = (x, y) =>
        {
            return x.OrderId - y.OrderId;
        };
        orderList.Sort(byOrderId);
    }

}
