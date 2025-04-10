public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        
        int[] daysInMonth = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        string[] dayOfWeek = {"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};

        int totalDays = b;
        for(int i = 1; i < a; i++){
            totalDays += daysInMonth[i];
        }

        answer = dayOfWeek[(totalDays - 1) % 7];
        
        return answer;
    }
}