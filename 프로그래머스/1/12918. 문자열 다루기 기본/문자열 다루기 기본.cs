using System;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        char[] hint = s.ToCharArray();
        if(s.Length == 4 || s.Length == 6){
            for(int i = 0; i < s.Length; i++){
                if((int)hint[i] > 47 && (int)hint[i] < 58){
                    answer = true;
                }
                else{
                    answer = false;
                    break;
                }
            }
        }
        else
            answer = false;
        return answer;
    }
}