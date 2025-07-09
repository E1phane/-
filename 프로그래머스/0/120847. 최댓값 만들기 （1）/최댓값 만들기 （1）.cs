using System;

public class Solution {
    public int solution(int[] numbers) {
        Array.Sort(numbers);
        int max1 = numbers[0] * numbers[1];
        int max2 = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
        
        return Math.Max(max1, max2);
    }
}