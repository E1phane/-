using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int index = 0;

        while (index < s.Length)
        {
            char x = s[index];
            int countX = 0;
            int countOther = 0;

            for (int i = index; i < s.Length; i++)
            {
                if (s[i] == x)
                    countX++;
                else
                    countOther++;

                if (countX == countOther)
                {
                    answer++;
                    index = i + 1;
                    break;
                }

                if (i == s.Length - 1)
                {
                    answer++;
                    index = s.Length;
                }
            }
        }

        return answer;
    }
}
