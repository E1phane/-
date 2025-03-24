using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        List<int> answer = new List<int>();
        
        for(int i = 0; i < commands.GetLength(0); i++){
            int start = commands[i,0] - 1;
            int end = commands[i,1];
            int k = commands[i,2] - 1;
            
            List<int> sublist = new List<int>(array);
            List<int> during = sublist.GetRange(start, end - start);
            during.Sort();    
            answer.Add(during[k]);
        }
        
        return answer.ToArray();
    }
}