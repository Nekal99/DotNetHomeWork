using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Product
{
	private readonly List<string> productName;
	private readonly List<double> price;
	public Product(List<string> productName,List<double> price)
	{
		this.productName = productName;
		this.price = price;
	}

	public List<string> ProductName { get { return productName; } }
	public List<double> Prices { get {  return price; } }

	public new void ToString()
	{
		for (int i = 0; i < productName.Count; i++)
		{
			Console.WriteLine("产品名：" + productName[i] + "价格：" + price[i]);
		}
    }
}
