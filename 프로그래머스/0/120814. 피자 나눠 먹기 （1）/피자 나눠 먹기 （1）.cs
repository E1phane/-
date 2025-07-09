using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        while(true){
            if(n <= 7){
                return answer;
            }
            if(n > 7){
               answer++;
                n = n - 7;
            }
        }
    }
}