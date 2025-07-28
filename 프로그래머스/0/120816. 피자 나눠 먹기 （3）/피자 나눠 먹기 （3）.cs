using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 1;
        while(true){
        if(slice * answer < n)
            answer++;
        if(slice * answer >= n)
            return answer;
        }
    }
}