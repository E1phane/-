using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int[] num = s.Split(' ').Select(int.Parse).ToArray();
        
        int min = num.Min();
        int max = num.Max();
        
        answer = $"{min} {max}";
        return answer;
    }
}