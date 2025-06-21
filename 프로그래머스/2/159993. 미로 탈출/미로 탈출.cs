using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] maps) {
        int n = maps.Length;
        int m = maps[0].Length;

        int[] dx = new int[] { -1, 1, 0, 0 };
        int[] dy = new int[] { 0, 0, -1, 1 };

        (int x, int y) start = (0, 0);
        (int x, int y) lever = (0, 0);
        (int x, int y) exit = (0, 0);

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (maps[i][j] == 'S') start = (i, j);
                else if (maps[i][j] == 'L') lever = (i, j);
                else if (maps[i][j] == 'E') exit = (i, j);
            }
        }

        int toLever = BFS(maps, start, lever, n, m, dx, dy);
        int toExit = BFS(maps, lever, exit, n, m, dx, dy);

        if (toLever == -1 || toExit == -1) return -1;
        return toLever + toExit;
    }

    private int BFS(string[] maps, (int x, int y) start, (int x, int y) goal, int n, int m, int[] dx, int[] dy) {
        bool[,] visited = new bool[n, m];
        Queue<((int x, int y) pos, int dist)> queue = new Queue<((int, int), int)>();
        queue.Enqueue((start, 0));
        visited[start.x, start.y] = true;

        while (queue.Count > 0) {
            var (pos, dist) = queue.Dequeue();
            if (pos.x == goal.x && pos.y == goal.y) return dist;

            for (int i = 0; i < 4; i++) {
                int nx = pos.x + dx[i];
                int ny = pos.y + dy[i];

                if (nx >= 0 && nx < n && ny >= 0 && ny < m &&
                    !visited[nx, ny] && maps[nx][ny] != 'X') {
                    visited[nx, ny] = true;
                    queue.Enqueue(((nx, ny), dist + 1));
                }
            }
        }
        return -1; // 도달 불가
    }
}
