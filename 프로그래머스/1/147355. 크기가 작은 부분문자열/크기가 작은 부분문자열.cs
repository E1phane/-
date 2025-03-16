using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        for(int i = 0; i < t.Length; i++){
            if(t.Length - i < p.Length)
                break;
            else{
                if(long.Parse(t.Substring(i, p.Length)) <= long.Parse(p))
                    answer++;
            }
        }
        return answer;
    }
}