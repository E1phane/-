using System;

public class Solution {
    public string solution(string s) {
        char[] answer = s.ToCharArray();
        for(int i = 0; i < answer.Length - 1; i++){
            for(int j = 0; j < answer.Length - i - 1; j++){
                if((int)answer[j] < (int)answer[j + 1]){
                char change = answer[j + 1];
                answer[j + 1] = answer[j];
                answer[j] = change;
                }            
            }
        }
        return new string(answer);
    }
}