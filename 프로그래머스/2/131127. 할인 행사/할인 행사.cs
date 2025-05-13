using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        int totalDays = discount.Length;

        for (int i = 0; i <= totalDays - 10; i++) {
            Dictionary<string, int> discountMap = new Dictionary<string, int>();

            for (int j = i; j < i + 10; j++) {
                if (discountMap.ContainsKey(discount[j])) {
                    discountMap[discount[j]]++;
                } else {
                    discountMap[discount[j]] = 1;
                }
            }

            // 원하는 물품과 개수가 맞는지 확인
            bool canSubscribe = true;
            for (int k = 0; k < want.Length; k++) {
                string item = want[k];
                int requiredCount = number[k];

                if (!discountMap.ContainsKey(item) || discountMap[item] < requiredCount) {
                    canSubscribe = false;
                    break;
                }
            }

            if (canSubscribe) {
                answer++;
            }
        }

        return answer;
    }
}
