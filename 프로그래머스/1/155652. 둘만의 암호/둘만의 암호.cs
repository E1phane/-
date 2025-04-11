using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string s, string skip, int index) {
        StringBuilder answer = new StringBuilder();
        HashSet<char> skipSet = new HashSet<char>(skip);
        
        foreach(char c in s){
            char temp = c;
            int count = 0;
            
            while(count < index){
                temp++;
                
                if(temp > 'z'){
                    temp = 'a';
                }
                
                if(skipSet.Contains(temp)){
                    continue;
                }
                
                count++;
            }
            answer.Append(temp);
        }
        
        return answer.ToString();
    }
}