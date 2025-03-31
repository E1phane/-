using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        int num1 = 0;
        int num2 = 0;
        for(int i = 0; i < goal.Length; i++){
            if(num1 < cards1.Length && goal[i] == cards1[num1]){                
                num1++;
            }
            else if(num2 < cards2.Length && goal[i] == cards2[num2]){                
                num2++;
            }
            else{
                answer = "No";
            }
        }
        return answer;
    }
}