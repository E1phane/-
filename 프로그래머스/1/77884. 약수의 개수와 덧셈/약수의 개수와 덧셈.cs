using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        for(int i = left; i <= right; i++){
            double sqrt = Math.Sqrt(i);
            if(sqrt == Math.Floor(sqrt)){
                answer -= i;
            }
            else{
                answer += i;
            }
        }
        return answer;
    }
}