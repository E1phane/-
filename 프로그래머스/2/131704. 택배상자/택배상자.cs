using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] order) {
        Stack<int> subBelt = new Stack<int>();
        int current = 1;
        int index = 0;
        int count = 0;
        
        while(index < order.Length){
            if(current == order[index]){
                count++;
                index++;
                current++;
            }
            else if(subBelt.Count > 0 && subBelt.Peek() == order[index]){
                subBelt.Pop();
                count++;
                index++;
            }
            else if(current <= order.Length){
                subBelt.Push(current);
                current++;
            }
            else{
                break;
            }
        }
        return count;
    }
}