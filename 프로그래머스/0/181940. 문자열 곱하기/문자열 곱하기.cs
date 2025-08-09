using System;

public class Solution {
    public string solution(string my_string, int k) {
        string answer = "";
        for(int i = 0; i < k; i++){
            for(int j = 0; j < my_string.Length; j++){
                answer += my_string[j];
            }
        }
        return answer;
    }
}