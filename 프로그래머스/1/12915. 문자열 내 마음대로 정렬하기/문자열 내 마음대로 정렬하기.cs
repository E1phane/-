using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[] {};
        
        answer = strings.OrderBy(word => word[n])
                        .ThenBy(word => word)
                        .ToArray();
        
        return answer;
    }
}