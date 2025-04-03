using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        for(int i = 1; i <= number; i++){
            int count = 0; 
            int sqrt = (int)Math.Sqrt(i);
            for(int j = 1; j <= sqrt; j++){
                if(i % j == 0){
                    count += (j == i / j) ? 1 : 2;
                }
            }
            if(count > limit){
                answer += power;
            }
            else{
                answer += count;
            }
        }
        return answer;
    }
}