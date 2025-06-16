using System;
using System.Linq;

public class Solution {
    public int solution(int[] arrayA, int[] arrayB) {
        int gcdA = arrayA.Aggregate(GCD);
        int gcdB = arrayB.Aggregate(GCD);

        int resultA = IsValidGCD(gcdA, arrayB) ? gcdA : 0;
        int resultB = IsValidGCD(gcdB, arrayA) ? gcdB : 0;

        return Math.Max(resultA, resultB);
    }

    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }

    private bool IsValidGCD(int candidate, int[] target) {
        foreach (int number in target) {
            if (number % candidate == 0) return false;
        }
        return true;
    }
}
