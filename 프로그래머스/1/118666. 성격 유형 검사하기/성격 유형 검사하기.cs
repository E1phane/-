using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string solution(string[] survey, int[] choices)
    {
        Dictionary<char, int> scoreDict = new Dictionary<char, int>()
        {
            { 'R', 0 }, { 'T', 0 },
            { 'C', 0 }, { 'F', 0 },
            { 'J', 0 }, { 'M', 0 },
            { 'A', 0 }, { 'N', 0 }
        };

        for (int i = 0; i < survey.Length; i++)
        {
            string type = survey[i];
            int choice = choices[i];

            char disagree = type[0];
            char agree = type[1];

            int score = Math.Abs(choice - 4);

            if (choice < 4)
            {
                scoreDict[disagree] += score;
            }
            else if (choice > 4)
            {
                scoreDict[agree] += score;
            }
        }

        StringBuilder result = new StringBuilder();
        result.Append(scoreDict['R'] >= scoreDict['T'] ? 'R' : 'T');
        result.Append(scoreDict['C'] >= scoreDict['F'] ? 'C' : 'F');
        result.Append(scoreDict['J'] >= scoreDict['M'] ? 'J' : 'M');
        result.Append(scoreDict['A'] >= scoreDict['N'] ? 'A' : 'N');

        return result.ToString();
    }
}