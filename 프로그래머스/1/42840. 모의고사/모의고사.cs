using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] supo1 = {1,2,3,4,5};
        int[] supo2 = {2,1,2,3,2,4,2,5};
        int[] supo3 = {3,3,1,1,2,2,4,4,5,5};
        int cor1 = 0, cor2 = 0, cor3 = 0;
        
        for(int i = 0; i < answers.Length; i++){
            if (answers[i] == supo1[i % supo1.Length]) cor1++;
            if (answers[i] == supo2[i % supo2.Length]) cor2++;
            if (answers[i] == supo3[i % supo3.Length]) cor3++;
        }
        
        int maxScore = Math.Max(cor1, Math.Max(cor2, cor3));
        
        List<int> winners = new List<int>();
        if (cor1 == maxScore) winners.Add(1);
        if (cor2 == maxScore) winners.Add(2);
        if (cor3 == maxScore) winners.Add(3);
        
        return winners.ToArray();
    }
}