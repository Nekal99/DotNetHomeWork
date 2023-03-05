//判断矩阵是否为托普利茨矩阵
bool IsSpecialMartix(int[][] matrix)
{
    int m = matrix.Length;
    int n = matrix[0].Length;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if(i+1 < m && n+1 <n)
            {
                if (matrix[i][j] != matrix[i + 1][n + 1])
                {
                    return false;
                }
            }
        }
    }
    return true;
}
int[][] matrix1 = { new int[]{ 1, 2, 3, 4 },new int[] { 5, 1, 2, 3 },new int[] {9,5,1,2 } };
if(IsSpecialMartix(matrix1))
{
    for (int i = 0; i < matrix1.Length; i++)
    {
        for (int j = 0; j < matrix1[0].Length; j++)
        {
            Console.Write(matrix1[i][j]+ " ");
        }
        Console.WriteLine("");
    }
}
