using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length == 1){
            return new int[] {-1};
        }
        int small = arr[0];
        for(int i = 0; i < arr.Length; i++){
            if(small > arr[i]){
                small = arr[i];
            }
        }
        
        List<int> answer = new List<int>();
        
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] != small){
                answer.Add(arr[i]);
            }
        }
        
        return answer.ToArray();
    }
}