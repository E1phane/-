using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        Stack<int> stack = new Stack<int>();
        int answer = 0;

        foreach (int ing in ingredient) {
            stack.Push(ing);

            if (stack.Count >= 4) {
                int[] temp = new int[4];

                for (int i = 3; i >= 0; i--) {
                    temp[i] = stack.Pop();
                }

                if (temp[0] == 1 && temp[1] == 2 && temp[2] == 3 && temp[3] == 1) {
                    answer++;
                } else {
                    for (int i = 0; i < 4; i++) {
                        stack.Push(temp[i]);
                    }
                }
            }
        }

        return answer;
    }
}