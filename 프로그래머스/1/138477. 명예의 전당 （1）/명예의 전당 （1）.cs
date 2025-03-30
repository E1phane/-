using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> honor = new List<int>();
        
        for(int i = 0; i < score.Length; i++){
            if(i < k){
                honor.Add(score[i]);
            }
            else{
                if(score[i] > honor[0]){
                    honor[0] = score[i];
                }
            }
            honor.Sort();
            answer[i] = honor[0];
        }
        
        return answer;
    }
}