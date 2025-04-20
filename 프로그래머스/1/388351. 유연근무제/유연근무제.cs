using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        int[] schedules2 = new int[schedules.Length];
        
        for(int i = 0; i < schedules.Length; i++){
            if((schedules[i] % 100) + 10 >= 60){
                schedules2[i] = schedules[i] - 60 + 100 + 10;
            }
            else{
                schedules2[i] = schedules[i] + 10;
            }
        }
        
        for(int i = 0; i < timelogs.GetLength(0); i++){
            bool present = true;
            if(startday < 7){
                timelogs[i, (6 - startday)] = 600;
                timelogs[i, (7 - startday)] = 600;
            }
            else{
                timelogs[i,6] = 600;
                timelogs[i,0] = 600;
            }
        
            for(int j = 0; j < timelogs.GetLength(1); j++){
                if(schedules2[i] < timelogs[i,j]){
                    present = false;
                }
            }
            if(present)
                answer++;
        }
        
        return answer;
    }
}