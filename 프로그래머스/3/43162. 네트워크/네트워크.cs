using System;

public class Solution {
    public int solution(int n, int[,] computers) {
        bool[] visited = new bool[n];
        int count = 0;

        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                DFS(i, computers, visited, n);
                count++;
            }
        }

        return count;
    }

    private void DFS(int current, int[,] computers, bool[] visited, int n) {
        visited[current] = true;

        for (int next = 0; next < n; next++) {
            if (computers[current, next] == 1 && !visited[next]) {
                DFS(next, computers, visited, n);
            }
        }
    }
}
