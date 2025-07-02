using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        Array.Sort(numbers);

        int n = numbers.Length;
        int max1 = numbers[n - 1] * numbers[n - 2];
        int max2 = numbers[0] * numbers[1];

        return Math.Max(max1, max2);
    }
}
