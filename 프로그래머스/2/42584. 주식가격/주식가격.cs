using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] prices) {
        int n = prices.Length;
        int[] answer = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++) {
            while (stack.Count > 0 && prices[stack.Peek()] > prices[i]) {
                int j = stack.Pop();
                answer[j] = i - j;
            }
            stack.Push(i);
        }

        while (stack.Count > 0) {
            int j = stack.Pop();
            answer[j] = n - 1 - j;
        }

        return answer;
    }
}
