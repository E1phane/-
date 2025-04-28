using System;

using System;

public class Solution{
    public bool solution(string s){
        int count = 0;

        foreach (char c in s)
        {
            if (c == '(')
            {
                count++;
            }
            else if (c == ')')
            {
                count--;
            }

            if (count < 0)
            {
                return false;
            }
        }

        return count == 0;
    }
}
