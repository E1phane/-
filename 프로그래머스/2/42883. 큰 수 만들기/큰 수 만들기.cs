using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string number, int k) {
        Stack<char> stack = new Stack<char>();

        foreach (char digit in number) {
            while (stack.Count > 0 && k > 0 && stack.Peek() < digit) {
                stack.Pop();
                k--;
            }
            stack.Push(digit);
        }

        while (k > 0) {
            stack.Pop();
            k--;
        }

        char[] result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}
