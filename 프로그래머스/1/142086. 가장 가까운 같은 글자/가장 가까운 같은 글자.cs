using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        for(int i = s.Length - 1; i >= 0; i--){
            for(int j = i - 1; j >= 0; j--){
                if(s[i] == s[j]){
                    answer[i] = i - j;
                    break;
                }
                else{
                    answer[i] = -1;
                }
            }
        }
        answer[0] = -1;
        return answer;
    }
}