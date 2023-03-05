Console.WriteLine("请输入整数数组的长度");
int inputNum = Int32.Parse(Console.ReadLine());
int[] inputArray = new int[inputNum];
Console.WriteLine("请输入整数");
int sum = 0;
int maxnum = 0;
int minnum = 0;
int averagenum = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    inputArray[i] = Convert.ToInt32(Console.ReadLine());
    sum += inputArray[i];
    if (i == 0)
    {
        maxnum = inputArray[i];
        minnum = inputArray[i];
    }
    if (maxnum < inputArray[i])
    {
        maxnum = inputArray[i];
    }
    
    if (inputArray[i] < minnum)
    {
        minnum = inputArray[i];
    }
}
averagenum = sum / inputArray.Length;
Console.WriteLine("数组的和为" + sum);
Console.WriteLine("数组的最大值为" + maxnum);
Console.WriteLine("数组的最小值为" + minnum);
Console.WriteLine("数组的平均值为" + averagenum);

