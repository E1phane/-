using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        string vowels = "aeiou";
        
        foreach(char c in my_string){
            if(!vowels.Contains(c))
                answer += c;
        }
        return answer;
    }
}