public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int day = 0;
        switch(a){
            case 1:
                break;
            case 2:
                day = 31;
                break;
            case 3:
                day = 31 + 29;
                break;
            case 4:
                day = 31 + 29 + 31;
                break;
            case 5:
                day = 31 + 29 + 31 + 30;
                break;
            case 6:
                day = 31 + 29 + 31 + 30 + 31;
                break;
            case 7:
                day = 31 + 29 + 31 + 30 + 31 + 30;
                break;
            case 8:
                day = 31 + 29 + 31 + 30 + 31 + 30 + 31;
                break;
            case 9:
                day = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
                break;
            case 10:
                day = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                break;
            case 11:
                day = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                break;
            case 12:
                day = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                break;
        }
        switch((day + b - 1) % 7){
            case 0:
                answer = "FRI";
                break;
            case 1:
                answer = "SAT";
                break;
            case 2:
                answer = "SUN";
                break;
            case 3:
                answer = "MON";
                break;
            case 4:
                answer = "TUE";
                break;
            case 5:
                answer = "WED";
                break;
            case 6:
                answer = "THU";
                break;
        }
        
        return answer;
    }
}