using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int w, int num) {
        int numIndex = num - 1;
        int level = numIndex / w;
        int col = 0;
        
        if(level % 2 == 0){
            col = numIndex % w;
        }
        else{
            col = w - 1 - (numIndex % w);
        }
        
        int answer = 1;
        
        for(int i = level + 1; i <= n; i++){
            int idx = 0;
            
            if(i % 2 == 0){
                idx = i * w + col;
            }
            else{
                idx = (i + 1) * w - 1 - col;
            }
            
            if(idx < n){
                answer++;    
            }
            else{
                break;
            }
        }
        
        return answer;
    }
}