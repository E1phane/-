using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        Dictionary<string, int> clothesDict = new Dictionary<string, int>();

        int len = clothes.GetLength(0);
        for (int i = 0; i < len; i++) {
            string type = clothes[i, 1];

            if (clothesDict.ContainsKey(type)) {
                clothesDict[type]++;
            } else {
                clothesDict[type] = 1;
            }
        }

        int answer = 1;
        foreach (var count in clothesDict.Values) {
            answer *= (count + 1);
        }

        return answer - 1;
    }
}
