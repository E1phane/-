using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int n = numbers.Length;
        int[] answer = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = n - 1; i >= 0; i--) {
            while (stack.Count > 0 && stack.Peek() <= numbers[i]) {
                stack.Pop();
            }

            answer[i] = stack.Count > 0 ? stack.Peek() : -1;

            stack.Push(numbers[i]);
        }

        return answer;
    }
}
