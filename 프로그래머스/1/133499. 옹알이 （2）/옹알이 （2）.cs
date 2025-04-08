using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] baleum = {"aya", "ye", "woo", "ma"};
        
        foreach(string word in babbling){
            string temp = word;
            string prev = "";
            
            bool isValid = true;
            
            while(temp.Length > 0){
                bool matched = false;
                
                foreach(string p in baleum){
                    if(temp.StartsWith(p) && prev != p){
                        prev = p;
                        temp = temp.Substring(p.Length);
                        matched = true;
                        break;
                    }
                }
                
                if(!matched){
                    isValid = false;
                    break;
                }
            }
            if(isValid){
                answer++;    
            }
        }
        return answer;
    }
}