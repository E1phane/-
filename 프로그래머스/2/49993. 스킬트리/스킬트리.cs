using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string skill, string[] skill_trees) {
        int validCount = 0;

        foreach (string tree in skill_trees) {
            int skillIndex = 0;
            bool isValid = true;

            foreach (char s in tree) {
                if (skill.Contains(s)) {
                    if (s == skill[skillIndex]) {
                        skillIndex++;
                    } else {
                        isValid = false;
                        break;
                    }
                }
            }

            if (isValid) validCount++;
        }

        return validCount;
    }
}
