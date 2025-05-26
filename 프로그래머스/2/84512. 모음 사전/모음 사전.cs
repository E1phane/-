using System;

public class Solution {
    public int solution(string word) {
        char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
        int[] weight = new int[5];
        int sum = 0;

        for (int i = 0; i < 5; i++) {
            weight[i] = 0;
            for (int j = i; j < 5; j++) {
                weight[i] += (int)Math.Pow(5, 4 - j);
            }
        }

        for (int i = 0; i < word.Length; i++) {
            int idx = Array.IndexOf(vowels, word[i]);
            sum += idx * weight[i] + 1;
        }

        return sum;
    }
}