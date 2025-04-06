using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int num = 0;
        
        while(num < section.Length){
            int start = section[num];
            int end = start + m - 1;
            answer++;
            
            while(num < section.Length && section[num] <= end){
                num++;
            }
        }
        return answer;
    }
}