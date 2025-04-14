using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        Array.Sort(lost);
        Array.Sort(reserve);

        for (int i = 0; i < lost.Length; i++) {
            for (int j = 0; j < reserve.Length; j++) {
                if (lost[i] == reserve[j]) {
                    lost[i] = -1;
                    reserve[j] = -1;
                    break;
                }
            }
        }

        for (int i = 0; i < lost.Length; i++) {
            if (lost[i] == -1) continue;

            for (int j = 0; j < reserve.Length; j++) {
                if (reserve[j] == -1) continue;

                if (Math.Abs(lost[i] - reserve[j]) == 1) {
                    reserve[j] = -1;
                    lost[i] = -1;
                    break;
                }
            }
        }

        int lostCount = 0;
        for (int i = 0; i < lost.Length; i++) {
            if (lost[i] != -1) lostCount++;
        }

        return n - lostCount;
    }
}