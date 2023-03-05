//设置是否为质数数组，如果对应的下标为质数，则值为1
int[] isPrim = new int[101];
for (int i = 2; i < 101; i++)
{
    isPrim[i] = 1;
    for (int j = 2; j < i - 1; j++)
    {
        if (i % j == 0)
        {
            isPrim[i] = 0;
        }
    }
}
Console.WriteLine("1-100的素数如下所示");
for (int i = 2; i < 101; i++)
{
    if (isPrim[i] == 1)
    {
        Console.Write(i+" ");
    }
}
