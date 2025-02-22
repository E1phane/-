public class Solution {
    public int[] solution(long n) {
        int i = 0;
        long temp = n;
        while(true) {
            if(temp > 0){
                i++;
                temp = temp / 10;
            }
            else
                break;       
        }
        int[] answer = new int[i];
        for(int j = 0; j < i; j++){
            answer[j] = (int) (n % 10);
            n = n / 10;
        }
        return answer;
    }
}