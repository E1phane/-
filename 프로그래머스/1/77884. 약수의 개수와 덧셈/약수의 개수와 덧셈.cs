using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        List<int> result = new List<int>();
        for(int i = left; i <= right; i++){
            result.Add(i);
        }
        foreach(int num in result){
            double sqrt = Math.Sqrt(num);
            if(sqrt == Math.Floor(sqrt)){
                answer -= num;
            }
            else{
                answer += num;
            }
        }
        return answer;
    }
}