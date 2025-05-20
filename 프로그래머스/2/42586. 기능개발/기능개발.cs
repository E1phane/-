using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> answer = new List<int>();
        
        Queue<int> days = new Queue<int>();
        for (int i = 0; i < progresses.Length; i++) {
            int remain = 100 - progresses[i];
            int day = (int)Math.Ceiling((double)remain / speeds[i]);
            days.Enqueue(day);
        }

        while (days.Count > 0) {
            int current = days.Dequeue();
            int count = 1;

            while (days.Count > 0 && days.Peek() <= current) {
                days.Dequeue();
                count++;
            }

            answer.Add(count);
        }

        return answer.ToArray();
    }
}
