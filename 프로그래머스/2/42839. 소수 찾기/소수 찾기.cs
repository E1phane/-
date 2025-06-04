using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string numbers) {
        HashSet<int> primeSet = new HashSet<int>();

        for (int i = 1; i <= numbers.Length; i++) {
            Permute("", numbers, i, primeSet);
        }

        int count = 0;
        foreach (int num in primeSet) {
            if (IsPrime(num)) count++;
        }

        return count;
    }

    private void Permute(string prefix, string remain, int length, HashSet<int> primeSet) {
        if (prefix.Length == length) {
            int num = int.Parse(prefix);
            primeSet.Add(num);
            return;
        }

        for (int i = 0; i < remain.Length; i++) {
            Permute(prefix + remain[i], remain.Substring(0, i) + remain.Substring(i + 1), length, primeSet);
        }
    }

    private bool IsPrime(int num) {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++) {
            if (num % i == 0) return false;
        }
        return true;
    }
}
