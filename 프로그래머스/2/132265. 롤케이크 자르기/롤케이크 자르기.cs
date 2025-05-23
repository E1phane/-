using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        Dictionary<int, int> right = new Dictionary<int, int>();
        HashSet<int> leftSet = new HashSet<int>();
        
        foreach (int t in topping) {
            if (right.ContainsKey(t)) right[t]++;
            else right[t] = 1;
        }

        int count = 0;

        for (int i = 0; i < topping.Length - 1; i++) {
            int current = topping[i];

            leftSet.Add(current);

            right[current]--;
            if (right[current] == 0) right.Remove(current);

            if (leftSet.Count == right.Count) {
                count++;
            }
        }

        return count;
    }
}
