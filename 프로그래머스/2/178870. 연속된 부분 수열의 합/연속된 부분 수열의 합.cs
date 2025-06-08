using System;

public class Solution {
    public int[] solution(int[] sequence, int k) {
        int n = sequence.Length;
        int left = 0, right = 0;
        int sum = sequence[0];

        int minLength = int.MaxValue;
        int answerStart = 0, answerEnd = 0;

        while (left < n && right < n) {
            if (sum == k) {
                if ((right - left) < minLength) {
                    minLength = right - left;
                    answerStart = left;
                    answerEnd = right;
                }

                sum -= sequence[left];
                left++;
            }
            else if (sum < k) {
                right++;
                if (right < n)
                    sum += sequence[right];
            }
            else {
                sum -= sequence[left];
                left++;
            }
        }

        return new int[] { answerStart, answerEnd };
    }
}
