using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int zero = 0, count = 0;
        
        for(int i = 0; i < lottos.Length; i++){
            if(lottos[i] == 0){
                zero++;
            }
        }
        
        for(int i = 0; i < lottos.Length; i++){
            for(int j = 0; j < win_nums.Length; j++){
                if(lottos[i]==win_nums[j]){
                    count++;
                    break;
                }
            }
        }
        
        int[] rank = {6,6,5,4,3,2,1};
        answer[0] = rank[zero + count];
        answer[1] = rank[count];
        
        return answer;
    }
}