using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] park, string[] routes)
    {
        int h = park.Length;
        int w = park[0].Length;
        int x = 0, y = 0;

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (park[i][j] == 'S')
                {
                    x = i;
                    y = j;
                    break;
                }
            }
        }

        Dictionary<string, (int dx, int dy)> directions = new Dictionary<string, (int dx, int dy)>()
        {
            { "N", (-1, 0) },
            { "S", (1, 0) },
            { "W", (0, -1) },
            { "E", (0, 1) }
        };

        foreach (string route in routes)
        {
            string[] split = route.Split(' ');
            string dir = split[0];
            int dist = int.Parse(split[1]);

            int nx = x;
            int ny = y;
            bool canMove = true;

            for (int i = 0; i < dist; i++)
            {
                nx += directions[dir].dx;
                ny += directions[dir].dy;

                if (nx < 0 || nx >= h || ny < 0 || ny >= w || park[nx][ny] == 'X')
                {
                    canMove = false;
                    break;
                }
            }

            if (canMove)
            {
                x = nx;
                y = ny;
            }
        }

        return new int[] { x, y };
    }
}
