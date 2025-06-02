using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] numbers) {
        var stringNumbers = numbers.Select(n => n.ToString()).ToList();

        stringNumbers.Sort((a, b) => (b + a).CompareTo(a + b));

        if (stringNumbers[0] == "0") return "0";

        return string.Join("", stringNumbers);
    }
}
