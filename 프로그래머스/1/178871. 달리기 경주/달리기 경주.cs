using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string[] answer = new string[players.Length];
        Dictionary<string, int> playerIndex = new Dictionary<string, int>();
        
        for(int i = 0; i < players.Length; i++){
            answer[i] = players[i];
            playerIndex[players[i]] = i;
        }
        
        foreach(string call in callings){
            int idx = playerIndex[call];
            string prevPlayer = answer[idx - 1];
            
            answer[idx - 1] = call;
            answer[idx] = prevPlayer;
            
            playerIndex[call] = idx - 1;
            playerIndex[prevPlayer] = idx;
        }
        
        return answer;
    }
}