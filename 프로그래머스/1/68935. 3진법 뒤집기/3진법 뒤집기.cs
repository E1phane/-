using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int power = 1;
        string result = "";
        
        while(n > 0){
            int remain = n % 3;
            result = remain.ToString() + result;
            n /= 3;
        }
        char[] reverse = result.ToCharArray();
        Array.Reverse(reverse);
        
        result = new string(reverse);
        
        for(int i = result.Length - 1; i >= 0; i--){
            int num = result[i] - '0';
            answer += num * power;
            power *= 3;
        }
        
        return answer;
    }
}