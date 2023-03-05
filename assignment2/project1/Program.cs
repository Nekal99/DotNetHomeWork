Console.WriteLine("请输入数组的长度");
int inputNum = Int32.Parse(Console.ReadLine());
int[] inputArray = new int[inputNum];
Console.WriteLine("请输入整数");
for (int i = 0; i < inputArray.Length; i++)
{
    inputArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("输入数组的结果为");
//判断一个数是否为素数，即只被1和数本身整除
static bool isPrim(int num)
{
	for (int i = 2; i < num - 1; i++)
	{
		if (num % i == 0)
		{
			return false;
		}
	}
    Console.WriteLine(num + "是素数");
	return true;
}
for (int j = 0; j < inputArray.Length; j++)
{
	isPrim(inputArray[j]);
}


