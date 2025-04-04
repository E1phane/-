using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        Array.Sort(score);
        Array.Reverse(score);
        int count = score.Length / m;
        
        for(int i = 0; i < count; i++){
            int profit = score[(i + 1) * m - 1];
            answer += profit * m;
        }
        
        return answer;
    }
}