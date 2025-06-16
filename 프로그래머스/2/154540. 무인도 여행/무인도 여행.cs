using System;
using System.Collections.Generic;

public class Solution {
    static int[] dx = new int[] { -1, 1, 0, 0 };
    static int[] dy = new int[] { 0, 0, -1, 1 };
    static int rows, cols;
    static bool[,] visited;

    public int[] solution(string[] maps) {
        rows = maps.Length;
        cols = maps[0].Length;
        visited = new bool[rows, cols];
        List<int> result = new List<int>();

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (!visited[i, j] && maps[i][j] != 'X') {
                    int sum = DFS(maps, i, j);
                    result.Add(sum);
                }
            }
        }

        if (result.Count == 0)
            return new int[] { -1 };

        result.Sort();
        return result.ToArray();
    }

    private int DFS(string[] maps, int x, int y) {
        Stack<(int, int)> stack = new Stack<(int, int)>();
        stack.Push((x, y));
        visited[x, y] = true;
        int sum = maps[x][y] - '0';

        while (stack.Count > 0) {
            var (curX, curY) = stack.Pop();

            for (int dir = 0; dir < 4; dir++) {
                int nx = curX + dx[dir];
                int ny = curY + dy[dir];

                if (nx >= 0 && ny >= 0 && nx < rows && ny < cols) {
                    if (!visited[nx, ny] && maps[nx][ny] != 'X') {
                        visited[nx, ny] = true;
                        sum += maps[nx][ny] - '0';
                        stack.Push((nx, ny));
                    }
                }
            }
        }

        return sum;
    }
}
