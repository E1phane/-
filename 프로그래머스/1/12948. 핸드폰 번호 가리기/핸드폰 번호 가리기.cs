public class Solution {
    public string solution(string phone_number) {
        char[] answer = phone_number.ToCharArray();
        for(int i = 0; i < answer.Length - 4; i++){
            answer[i] = '*';
        }
        return new string(answer);
    }
}