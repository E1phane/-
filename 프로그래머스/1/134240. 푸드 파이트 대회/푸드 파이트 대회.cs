using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        List<int> ans = new List<int>();
        
        for(int i = 1; i < food.Length; i++){
            ans.Add(food[i] / 2);
        }
        
        int num = 1;
        
        foreach(int count in ans){
            for(int i = 0; i < count; i++){
                answer += num.ToString();
            }
            num++;
        }
        
        num--;
        answer += "0";
        ans.Reverse();
        
        foreach(int count in ans){
            for(int i = 0; i < count; i++){
                answer += num.ToString();
            }
            num--;
        }
        
        return answer;
    }
}