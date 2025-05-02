using System;

public class Solution {
    public int solution(int n) {
        int countOnes = CountOnes(n);
        int nextNumber = n + 1;

        while (true) {
            if (CountOnes(nextNumber) == countOnes) {
                return nextNumber;
            }
            nextNumber++;
        }
    }

    private int CountOnes(int number) {
        int count = 0;
        while (number > 0) {
            if ((number & 1) == 1) count++;
            number >>= 1;
        }
        return count;
    }
}