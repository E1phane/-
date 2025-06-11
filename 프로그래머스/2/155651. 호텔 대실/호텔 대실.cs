using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[,] book_time) {
        int n = book_time.GetLength(0);

        var bookings = new List<(int start, int end)>();
        for (int i = 0; i < n; i++) {
            int start = ToMinutes(book_time[i, 0]);
            int end = ToMinutes(book_time[i, 1]) + 10;
            bookings.Add((start, end));
        }

        bookings.Sort((a, b) => a.start.CompareTo(b.start));

        var roomEndTimes = new List<int>();

        foreach (var booking in bookings) {
            bool assigned = false;

            for (int i = 0; i < roomEndTimes.Count; i++) {
                if (roomEndTimes[i] <= booking.start) {
                    roomEndTimes[i] = booking.end;
                    assigned = true;
                    break;
                }
            }

            if (!assigned) {
                roomEndTimes.Add(booking.end);
            }

            roomEndTimes.Sort();
        }

        return roomEndTimes.Count;
    }

    private int ToMinutes(string time) {
        var parts = time.Split(':');
        int hour = int.Parse(parts[0]);
        int minute = int.Parse(parts[1]);
        return hour * 60 + minute;
    }
}
