using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        Dictionary<int, int> sizeCount = new Dictionary<int, int>();
        foreach (int size in tangerine) {
            if (!sizeCount.ContainsKey(size))
                sizeCount[size] = 0;
            sizeCount[size]++;
        }

        List<int> counts = sizeCount.Values.OrderByDescending(x => x).ToList();

        int sum = 0;
        int typeCount = 0;

        foreach (int count in counts) {
            sum += count;
            typeCount++;
            if (sum >= k)
                break;
        }

        return typeCount;
    }
}
