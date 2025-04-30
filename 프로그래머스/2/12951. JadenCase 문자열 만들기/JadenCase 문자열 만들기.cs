public class Solution {
    public string solution(string s) {
        s = s.ToLower();
        char[] chars = s.ToCharArray();
        
        bool isStartOfWord = true;
        for (int i = 0; i < chars.Length; i++) {
            if (isStartOfWord && char.IsLetter(chars[i])) {
                chars[i] = char.ToUpper(chars[i]);
                isStartOfWord = false;
            } else if (chars[i] == ' ') {
                isStartOfWord = true;
            } else {
                isStartOfWord = false;
            }
        }

        return new string(chars);
    }
}
