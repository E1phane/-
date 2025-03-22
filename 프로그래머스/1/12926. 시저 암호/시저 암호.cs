public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] array = s.ToCharArray();
        for(int i = 0; i < s.Length; i++){
            if(array[i] == ' '){
                continue;
            }
            if(array[i] >= 'A' && array[i] <= 'Z' && (array[i] + n) > 'Z'){
                array[i] = (char)(array[i] + n - 26);
            }
            else if(array[i] >= 'a' && array[i] <= 'z' && (array[i] + n) > 'z'){
                array[i] = (char)(array[i] + n - 26);
            }
            else{
                array[i] = (char)(array[i] + n);
            }
        }
        return new string(array);
    }
}