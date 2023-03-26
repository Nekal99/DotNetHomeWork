using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class OrderDetails
{
	private readonly Order order;
	private readonly string address;
	private readonly string description;
	public OrderDetails(Order order, string address, string description)
	{
		this.order = order;
		this.address = address;
		this.description = description;
	}

	public string Address
	{
		get
		{
			return address;

		}
	}

	public string Description
	{
		get
		{
			return description;
		}
	}

	public bool Equals(OrderDetails orderDetails)
	{
		if(this.address == orderDetails.address&&this.description == orderDetails.description) {
			return true;
		}
		return false;
	}

	public new void ToString()
	{
		order.ToString();
        Console.WriteLine("地址："+ this.address);
        Console.WriteLine("备注：" + this.description);
    }
}
