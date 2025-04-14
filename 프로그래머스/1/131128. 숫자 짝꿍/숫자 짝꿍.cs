using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        int[] xCount = new int[10];
        int[] yCount = new int[10];
        
        foreach(char c in X){
            xCount[c - '0']++;
        }
        foreach(char c in Y){
            yCount[c - '0']++;
        }
        
        StringBuilder result = new StringBuilder();
        
        for(int i = 9; i >= 0; i--){
            int pair = Math.Min(xCount[i], yCount[i]);
            result.Append(new string((char)(i + '0'), pair));
        }
        
        if(result.Length == 0)
            return "-1";
        
        if(result[0] == '0')
            return "0";
        
        return result.ToString();
    }
}