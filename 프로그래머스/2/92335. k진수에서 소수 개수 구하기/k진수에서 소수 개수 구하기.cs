using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public int solution(int n, int k) {
        string converted = ConvertToBase(n, k);
        string[] tokens = converted.Split('0');
        int count = 0;

        foreach (string token in tokens) {
            if (string.IsNullOrEmpty(token)) continue;
            if (token.Contains("0")) continue;

            long num = long.Parse(token);
            if (IsPrime(num)) count++;
        }

        return count;
    }

    private string ConvertToBase(int n, int k) {
        StringBuilder sb = new StringBuilder();
        while (n > 0) {
            sb.Insert(0, n % k);
            n /= k;
        }
        return sb.ToString();
    }

    private bool IsPrime(long num) {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        long sqrt = (long)Math.Sqrt(num);
        for (long i = 3; i <= sqrt; i += 2) {
            if (num % i == 0) return false;
        }
        return true;
    }
}
