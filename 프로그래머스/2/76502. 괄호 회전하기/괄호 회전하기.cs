using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int count = 0;
        int n = s.Length;

        for (int i = 0; i < n; i++) {
            string rotated = s.Substring(i) + s.Substring(0, i);
            if (IsValid(rotated)) {
                count++;
            }
        }

        return count;
    }

    private bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            } else {
                if (stack.Count == 0) return false;

                char top = stack.Pop();

                if (c == ')' && top != '(') return false;
                if (c == ']' && top != '[') return false;
                if (c == '}' && top != '{') return false;
            }
        }

        return stack.Count == 0;
    }
}
