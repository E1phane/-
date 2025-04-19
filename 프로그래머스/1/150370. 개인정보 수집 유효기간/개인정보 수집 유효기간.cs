using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>{};
        string[] dayparts = today.Split('.');
        int year = int.Parse(dayparts[0]);
        int month = int.Parse(dayparts[1]);
        int day = int.Parse(dayparts[2]);
        int todayNum = year * 12 * 28 + month * 28 + day;
        
        foreach (string item in terms){
            string[] parts = item.Split(' ');
            string termCha = parts[0];
            int periodNum = int.Parse(parts[1]);
            
            for(int i = 0; i < privacies.Length; i++){
                string[] privacy = privacies[i].Split(' ');
                string date = privacy[0];
                string period = privacy[1];
                
                if(period == termCha){
                    string[] termparts = date.Split('.');
                    int termYear = int.Parse(termparts[0]);
                    int termMonth = int.Parse(termparts[1]);
                    int termDay = int.Parse(termparts[2]);
                    int termNum = termYear * 12 * 28 + termMonth * 28 + termDay;
                    
                    if(todayNum >= termNum + periodNum * 28){
                        answer.Add(i+1);
                        answer.Sort();
                    }
                    
                }
                else{
                    continue;
                }
            }
        }
        return answer.ToArray();
    }
}