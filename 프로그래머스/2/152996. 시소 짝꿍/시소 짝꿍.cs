using System;
using System.Collections.Generic;

public class Solution {
    public long solution(int[] weights) {
        var weightCounts = new Dictionary<int, long>();
        foreach (var w in weights) {
            if (!weightCounts.ContainsKey(w))
                weightCounts[w] = 0;
            weightCounts[w]++;
        }

        long result = 0;

        var ratios = new List<(int, int)> {
            (1,1), (2,3), (1,2), (3,2), (3,4), (2,1), (4,3)
        };

        foreach (var w in weights) {
            weightCounts[w]--;

            foreach (var ratio in ratios) {
                int a = ratio.Item1;
                int b = ratio.Item2;

                long target = w * a;
                if (target % b != 0) continue;

                int match = (int)(target / b);
                if (weightCounts.ContainsKey(match)) {
                    result += weightCounts[match];
                }
            }

            weightCounts[w]++;
        }

        return result / 2;
    }
}
