using System;

public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int rows1 = arr1.GetLength(0);
        int cols1 = arr1.GetLength(1);
        int cols2 = arr2.GetLength(1);

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += arr1[i, k] * arr2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }
}
