using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] elements)
    {
        int n = elements.Length;
        HashSet<int> sumSet = new HashSet<int>();
        int[] extended = new int[n * 2];

        for (int i = 0; i < n * 2; i++)
        {
            extended[i] = elements[i % n];
        }

        for (int length = 1; length <= n; length++)
        {
            for (int start = 0; start < n; start++)
            {
                int sum = 0;
                for (int k = 0; k < length; k++)
                {
                    sum += extended[start + k];
                }
                sumSet.Add(sum);
            }
        }

        return sumSet.Count;
    }
}
