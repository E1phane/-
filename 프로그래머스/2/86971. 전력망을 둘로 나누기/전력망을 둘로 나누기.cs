using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[,] wires) {
        int answer = n;

        for (int i = 0; i < wires.GetLength(0); i++) {
            // 그래프 초기화
            List<int>[] graph = new List<int>[n + 1];
            for (int j = 1; j <= n; j++) {
                graph[j] = new List<int>();
            }

            // 간선 연결 (i번째 간선은 제외)
            for (int j = 0; j < wires.GetLength(0); j++) {
                if (i == j) continue;
                int a = wires[j, 0];
                int b = wires[j, 1];
                graph[a].Add(b);
                graph[b].Add(a);
            }

            // 하나의 네트워크 크기 구하기
            int count = BFS(1, graph, n);
            int diff = Math.Abs(n - 2 * count);
            answer = Math.Min(answer, diff);
        }

        return answer;
    }

    private int BFS(int start, List<int>[] graph, int n) {
        bool[] visited = new bool[n + 1];
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;
        int count = 1;

        while (queue.Count > 0) {
            int node = queue.Dequeue();
            foreach (int neighbor in graph[node]) {
                if (!visited[neighbor]) {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                    count++;
                }
            }
        }

        return count;
    }
}
