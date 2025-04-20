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
            foreach(int num in schedules){
            if(startday == 1){
                timelogs[i,5] = 600;
                timelogs[i,6] = 600;
            }
            if(startday == 2){
                timelogs[i,4] = 600;
                timelogs[i,5] = 600;
            }
            if(startday == 3){
                timelogs[i,3] = 600;
                timelogs[i,4] = 600;
            }
            if(startday == 4){
                timelogs[i,2] = 600;
                timelogs[i,3] = 600;
            }
            if(startday == 5){
                timelogs[i,1] = 600;
                timelogs[i,2] = 600;
            }
            if(startday == 6){
                timelogs[i,0] = 600;
                timelogs[i,1] = 600;
            }
            if(startday == 7){
                timelogs[i,6] = 600;
                timelogs[i,0] = 600;
            }
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