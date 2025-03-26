using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        List<string> sentence = new List<string>{s};
        List<int> ans = new List<int>();
        
        Dictionary<string, int> numDic = new Dictionary<string, int>{
            {"one", 1}, {"1", 1},
            {"two", 2}, {"2", 2},
            {"three", 3}, {"3", 3},
            {"four", 4}, {"4", 4},
            {"five", 5}, {"5", 5},
            {"six", 6}, {"6", 6},
            {"seven", 7}, {"7", 7},
            {"eight", 8}, {"8", 8},
            {"nine", 9}, {"9", 9},
            {"zero", 0}, {"0", 0}
        };
        
        for(int i = 0; i < s.Length; i++){
            foreach (var str in numDic) {
                string key = str.Key;
                int value = str.Value;
                
                if(s.Substring(i).StartsWith(key)){
                    ans.Add(value);
                    break;
                }
            }
        }
        
        string numStr = string.Join("", ans);
        return numStr == "" ? 0 : int.Parse(numStr);
    }
}