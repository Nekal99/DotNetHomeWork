using System;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
	private readonly string name;
	public User(string name)
	{
		this.name = name;
	}
	public string Name
	{
		get { return name; }
	}
	public new void ToString()
	{
		Console.WriteLine("用户名：" + this.name);
    }
}
