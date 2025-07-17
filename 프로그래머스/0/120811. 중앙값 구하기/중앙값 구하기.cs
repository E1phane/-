using System;

public class Solution {
    public int solution(int[] array) {
        int num = array.Length / 2;
        Array.Sort(array);
        int answer = array[num];
        return answer;
    }
}