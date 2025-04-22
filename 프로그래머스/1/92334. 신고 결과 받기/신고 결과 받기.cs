using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        
        HashSet<string> reportSet = new HashSet<string>(report);
        
        Dictionary<string, List<string>> reportedDict = new Dictionary<string, List<string>>();
        Dictionary<string, int> mailCount = new Dictionary<string, int>();
        
        foreach(string id in id_list){
            reportedDict[id] = new List<string>();
            mailCount[id] = 0;
        }
        
        foreach(string r in reportSet){
            string[] parts = r.Split(' ');
            string reporter = parts[0];
            string reported = parts[1];
            
            reportedDict[reported].Add(reporter);
        }
        
        foreach(var entry in reportedDict){
            if(entry.Value.Count >= k){
                foreach(string reporter in entry.Value){
                    mailCount[reporter]++;
                }
            }
        }
        
        for(int i = 0; i < id_list.Length; i++){
            answer[i] = mailCount[id_list[i]];
        }
        
        return answer;
    }
}