using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, string[] words) {
        HashSet<string> usedWords = new HashSet<string>();
        usedWords.Add(words[0]);

        for (int i = 1; i < words.Length; i++) {
            string prev = words[i - 1];
            string current = words[i];

            if (current[0] != prev[prev.Length - 1] || usedWords.Contains(current)) {
                int player = (i % n) + 1;
                int turn = (i / n) + 1;
                return new int[] { player, turn };
            }

            usedWords.Add(current);
        }

        return new int[] { 0, 0 };
    }
}
