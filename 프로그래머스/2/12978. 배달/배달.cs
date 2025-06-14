using System;
using System.Collections.Generic;

public class Solution
{
    class Node : IComparable<Node>
    {
        public int Index;
        public int Distance;

        public Node(int index, int distance)
        {
            Index = index;
            Distance = distance;
        }

        public int CompareTo(Node other)
        {
            return this.Distance.CompareTo(other.Distance);
        }
    }

    public int solution(int N, int[,] road, int K)
    {
        List<(int, int)>[] graph = new List<(int, int)>[N + 1];
        for (int i = 0; i <= N; i++)
        {
            graph[i] = new List<(int, int)>();
        }

        for (int i = 0; i < road.GetLength(0); i++)
        {
            int a = road[i, 0];
            int b = road[i, 1];
            int c = road[i, 2];
            graph[a].Add((b, c));
            graph[b].Add((a, c));
        }

        int[] dist = new int[N + 1];
        for (int i = 1; i <= N; i++) dist[i] = int.MaxValue;
        dist[1] = 0;

        // 우선순위 큐 대체: SortedSet 또는 List + 정렬
        var pq = new List<Node>();
        pq.Add(new Node(1, 0));

        while (pq.Count > 0)
        {
            pq.Sort(); // 거리 기준으로 정렬 (가장 짧은 거리 우선)
            Node current = pq[0];
            pq.RemoveAt(0);

            if (current.Distance > dist[current.Index]) continue;

            foreach (var edge in graph[current.Index])
            {
                int next = edge.Item1;
                int cost = edge.Item2 + current.Distance;

                if (cost < dist[next])
                {
                    dist[next] = cost;
                    pq.Add(new Node(next, cost));
                }
            }
        }

        int count = 0;
        for (int i = 1; i <= N; i++)
        {
            if (dist[i] <= K) count++;
        }

        return count;
    }
}
