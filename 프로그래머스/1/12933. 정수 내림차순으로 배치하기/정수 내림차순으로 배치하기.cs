public class Solution {
    public long solution(long n) {
        long answer = 0;
        int num = n.ToString().Length;
        long[] array = new long[num];
        long temp = n;
        for(int i = 0; i < num; i++){
            array[i] = temp % 10;
            temp /= 10;
        }
        
        for(int i = 0; i < num - 1; i++){
            for(int j = 0; j < num - 1 - i; j++){
                if(array[j] < array[j+1]){
                    long change = array[j];
                    array[j] = array[j+1];
                    array[j+1] = change;
                }
            }
        }
        
        for(int i = 0; i < num; i++){
             answer = answer * 10 + array[i];
        }
        return answer;
    }
}