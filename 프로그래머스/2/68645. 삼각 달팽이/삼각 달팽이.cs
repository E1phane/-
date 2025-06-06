using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[,] triangle = new int[n, n];
        int num = 1;
        int x = -1, y = 0;
        for (int layer = 0; layer < n; layer++) {
            for (int i = layer; i < n; i++) {
                if (layer % 3 == 0) {
                    x++;
                } else if (layer % 3 == 1) {
                    y++;
                } else {
                    x--;
                    y--;
                }
                triangle[x, y] = num++;
            }
        }

        List<int> result = new List<int>();
        for (int i = 0; i < n; i++) {
            for (int j = 0; j <= i; j++) {
                result.Add(triangle[i, j]);
            }
        }

        return result.ToArray();
    }
}
