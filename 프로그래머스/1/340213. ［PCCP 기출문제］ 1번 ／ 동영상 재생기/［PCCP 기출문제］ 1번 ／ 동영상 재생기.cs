using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        int videoLength = TimeToSeconds(video_len);
        int position = TimeToSeconds(pos);
        int opStart = TimeToSeconds(op_start);
        int opEnd = TimeToSeconds(op_end);
        
        foreach(string command in commands){
            if(position >= opStart && position <= opEnd){
                position = opEnd;
            }
            
            if(command == "prev"){
                position = Math.Max(0, position - 10);
            }
            else if(command == "next"){
                position = Math.Min(videoLength, position + 10);
            }
            
            if(position >= opStart && position <= opEnd){
                position = opEnd;
            }
        }
        
        int min = position / 60;
        int sec = position % 60;
        return $"{min:D2}:{sec:D2}";
    }
    
    private int TimeToSeconds(string time){
        string[] parts = time.Split(':');
        int min = int.Parse(parts[0]);
        int sec = int.Parse(parts[1]);
        return min * 60 + sec;
    }
}