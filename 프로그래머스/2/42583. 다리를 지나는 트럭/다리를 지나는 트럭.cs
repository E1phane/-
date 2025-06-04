using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        Queue<int> bridge = new Queue<int>();
        int time = 0;
        int bridgeWeight = 0;
        int truckIndex = 0;

        for (int i = 0; i < bridge_length; i++) {
            bridge.Enqueue(0);
        }

        while (bridge.Count > 0) {
            time++;

            bridgeWeight -= bridge.Dequeue();

            if (truckIndex < truck_weights.Length) {
                if (bridgeWeight + truck_weights[truckIndex] <= weight) {
                    bridge.Enqueue(truck_weights[truckIndex]);
                    bridgeWeight += truck_weights[truckIndex];
                    truckIndex++;
                } else {
                    bridge.Enqueue(0);
                }
            }
        }

        return time;
    }
}
