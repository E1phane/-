using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int count = 0;
        int zeroCount = 0;

        while (s != "1") {
            int originalLength = s.Length;
            s = s.Replace("0", "");
            int onesLength = s.Length;
            zeroCount += originalLength - onesLength;

            s = Convert.ToString(onesLength, 2);
            count++;
        }

        return new int[] { count, zeroCount };
    }
}
