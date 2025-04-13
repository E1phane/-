using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        // 각 문자에 대해 최소 몇 번 눌러야 하는지 저장할 딕셔너리
        Dictionary<char, int> minPressCount = new Dictionary<char, int>();

        // keymap을 순회하며 각 문자의 최소 누름 횟수 저장
        for (int i = 0; i < keymap.Length; i++)
        {
            for (int j = 0; j < keymap[i].Length; j++)
            {
                char c = keymap[i][j];
                int pressCount = j + 1; // 인덱스는 0부터 시작하므로 +1

                if (minPressCount.ContainsKey(c))
                {
                    minPressCount[c] = Math.Min(minPressCount[c], pressCount);
                }
                else
                {
                    minPressCount[c] = pressCount;
                }
            }
        }

        int[] result = new int[targets.Length];

        for (int i = 0; i < targets.Length; i++)
        {
            int totalPress = 0;
            bool possible = true;

            foreach (char c in targets[i])
            {
                if (minPressCount.ContainsKey(c))
                {
                    totalPress += minPressCount[c];
                }
                else
                {
                    // 입력할 수 없는 문자가 있음
                    totalPress = -1;
                    possible = false;
                    break;
                }
            }

            result[i] = totalPress;
        }

        return result;
    }
}
