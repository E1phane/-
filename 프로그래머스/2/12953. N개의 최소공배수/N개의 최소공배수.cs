public class Solution {
    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private int LCM(int a, int b) {
        return a * b / GCD(a, b);
    }

    public int solution(int[] arr) {
        int answer = arr[0];
        for (int i = 1; i < arr.Length; i++) {
            answer = LCM(answer, arr[i]);
        }
        return answer;
    }
}
