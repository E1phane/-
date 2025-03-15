public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min = n * m, max = 0;
        
        while(true){
            if(n % min == 0 && m % min == 0){
                answer[0] = min;
                break;
            }
            min--;
        }
        max = min * (n / min) * (m / min);    
        answer[1] = max;
        return answer;
    }
}