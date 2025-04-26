using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] friends, string[] gifts)
    {
        int n = friends.Length;

        Dictionary<string, int> nameToIndex = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
            nameToIndex[friends[i]] = i;

        int[,] giftCount = new int[n, n];
        int[] give = new int[n];
        int[] receive = new int[n];

        foreach (string record in gifts)
        {
            string[] parts = record.Split(' ');
            int from = nameToIndex[parts[0]];
            int to = nameToIndex[parts[1]];
            giftCount[from, to]++;
            give[from]++;
            receive[to]++;
        }

        int[] score = new int[n];
        for (int i = 0; i < n; i++)
            score[i] = give[i] - receive[i];

        int[] nextGifts = new int[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (giftCount[i, j] > giftCount[j, i])
                {
                    nextGifts[i]++;
                }
                else if (giftCount[i, j] < giftCount[j, i])
                {
                    nextGifts[j]++;
                }
                else
                {
                    if (score[i] > score[j])
                        nextGifts[i]++;
                    else if (score[i] < score[j])
                        nextGifts[j]++;
                }
            }
        }

        int maxGift = 0;
        foreach (int gift in nextGifts)
            maxGift = Math.Max(maxGift, gift);

        return maxGift;
    }
}
