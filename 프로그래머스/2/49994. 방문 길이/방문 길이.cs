using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string dirs)
    {
        HashSet<string> visited = new HashSet<string>();
        int x = 0, y = 0;
        int[,] move = new int[,] {
            {0, 1},   // U
            {0, -1},  // D
            {1, 0},   // R
            {-1, 0}   // L
        };
        Dictionary<char, int> dirMap = new Dictionary<char, int> {
            {'U', 0}, {'D', 1}, {'R', 2}, {'L', 3}
        };

        foreach (char dir in dirs)
        {
            int idx = dirMap[dir];
            int nx = x + move[idx, 0];
            int ny = y + move[idx, 1];

            if (nx < -5 || nx > 5 || ny < -5 || ny > 5)
                continue;

            string path1 = $"{x},{y},{nx},{ny}";
            string path2 = $"{nx},{ny},{x},{y}";

            visited.Add(path1);
            visited.Add(path2);

            x = nx;
            y = ny;
        }

        return visited.Count / 2;
    }
}
