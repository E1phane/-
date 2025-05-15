using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, long left, long right) {
        List<int> answer = new List<int>();

        for (long i = left; i <= right; i++) {
            long row = i / n;
            long col = i % n;
            answer.Add((int)(Math.Max(row, col) + 1));
        }

        return answer.ToArray();
    }
}
