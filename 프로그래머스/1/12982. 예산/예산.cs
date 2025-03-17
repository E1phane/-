using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        Array.Sort(d);
        foreach(int i in d){
            budget -= i;
            if(budget < 0)
                break;
            answer++;
        }
        return answer;
    }
}