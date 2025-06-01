using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] fees, string[] records) {
        int baseTime = fees[0];
        int baseFee = fees[1];
        int unitTime = fees[2];
        int unitFee = fees[3];

        // 차량별 입차 시각 기록
        Dictionary<string, int> inTime = new Dictionary<string, int>();
        // 차량별 누적 주차 시간
        Dictionary<string, int> totalTime = new Dictionary<string, int>();

        foreach (string record in records) {
            string[] parts = record.Split(' ');
            string[] timeParts = parts[0].Split(':');
            int minutes = int.Parse(timeParts[0]) * 60 + int.Parse(timeParts[1]);
            string carNumber = parts[1];
            string action = parts[2];

            if (action == "IN") {
                inTime[carNumber] = minutes;
            } else { // OUT
                int inMinutes = inTime[carNumber];
                int parkedTime = minutes - inMinutes;
                if (totalTime.ContainsKey(carNumber)) {
                    totalTime[carNumber] += parkedTime;
                } else {
                    totalTime[carNumber] = parkedTime;
                }
                inTime.Remove(carNumber); // 출차했으니 제거
            }
        }

        // 출차되지 않은 차량 처리 (23:59 출차로 간주)
        foreach (var entry in inTime) {
            string carNumber = entry.Key;
            int inMinutes = entry.Value;
            int parkedTime = (23 * 60 + 59) - inMinutes;
            if (totalTime.ContainsKey(carNumber)) {
                totalTime[carNumber] += parkedTime;
            } else {
                totalTime[carNumber] = parkedTime;
            }
        }

        // 차량 번호로 정렬하고 요금 계산
        var result = totalTime.OrderBy(t => t.Key)
                              .Select(t => CalculateFee(t.Value, baseTime, baseFee, unitTime, unitFee))
                              .ToArray();
        return result;
    }

    private int CalculateFee(int time, int baseTime, int baseFee, int unitTime, int unitFee) {
        if (time <= baseTime) {
            return baseFee;
        } else {
            double extraTime = time - baseTime;
            int units = (int)Math.Ceiling(extraTime / unitTime);
            return baseFee + units * unitFee;
        }
    }
}
