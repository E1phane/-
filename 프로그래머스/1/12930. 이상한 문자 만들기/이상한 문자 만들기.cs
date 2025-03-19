public class Solution {
    public string solution(string s) {
        string[] words = s.Split(' ');
        for(int i = 0; i < words.Length; i++){
            char[] array = words[i].ToCharArray();
            for(int j = 0; j < array.Length; j++){
                if(j % 2 == 0){
                    array[j] = char.ToUpper(array[j]);
                }
                else{
                    array[j] = char.ToLower(array[j]);
                }
            }
            words[i] = new string(array);
        }
        
        return string.Join(" ", words);
    }
}