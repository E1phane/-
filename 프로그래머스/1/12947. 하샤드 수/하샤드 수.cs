public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int size = 0;        
        int y = x;
        int z = x;
        while(y > 0){
            y = y / 10;
            size++;
        }
        int[] num = new int[size];
        for(int i = 0; i < size; i++){
            num[i] = z % 10;
            z = z / 10;
        }
        int temp = 0;
        for(int i = 0; i < size; i++){
            temp += num[i];
        }
        if(x % temp == 0)
            answer = true;        
        else
            answer = false;
        return answer;
    }
}