public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int find = 0;
        for(int i = 0; i < seoul.Length; i++){
            if(seoul[i] == "Kim")
                find = i;
        }
        answer = "김서방은 " + find + "에 있다";
        return answer;
    }
}