using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        for(int i = 0; i < nums.Length - 2; i++){
            for(int j = i + 1; j < nums.Length - 1; j++){
                for(int k = j + 1; k < nums.Length; k++){
                    int sum = nums[i] + nums[j] + nums[k];
                    if(IsPrime(sum)){
                        answer++;
                    }
                }
            }
        }

        return answer;
    }
    
    private bool IsPrime(int n)
    {
        if (n < 2) return false;
        for(int i = 2; i * i <= n; i++){
            if(n % i == 0) return false;
        }
        return true;
    }
}