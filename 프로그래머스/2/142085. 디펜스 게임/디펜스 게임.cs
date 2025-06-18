using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int k, int[] enemy) {
        var maxHeap = new SortedSet<(int val, int idx)>();
        long soldier = n;

        for (int i = 0; i < enemy.Length; i++) {
            soldier -= enemy[i];
            maxHeap.Add((enemy[i], i));

            if (soldier < 0) {
                if (k > 0) {
                    var max = maxHeap.Max;
                    soldier += max.val;
                    maxHeap.Remove(max);
                    k--;
                } else {
                    return i;
                }
            }
        }

        return enemy.Length;
    }
}
