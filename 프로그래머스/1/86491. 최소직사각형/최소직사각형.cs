using System;

public class Solution {
    public int solution(int[,] sizes) {
        int maxWidth = 0;
        int maxHeight = 0;
        for(int i = 0; i < sizes.GetLength(0); i++){
            int w = sizes[i,0];
            int h = sizes[i,1];
            
            if(w < h){
                int temp = w;
                w = h;
                h = temp;
            }
            
            maxWidth = Math.Max(maxWidth, w);
            maxHeight = Math.Max(maxHeight, h);
        }
        
        return maxWidth * maxHeight;
    }
}