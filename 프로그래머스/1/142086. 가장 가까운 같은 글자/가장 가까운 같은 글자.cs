using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        List<char> result = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (result.LastIndexOf(s[i]) == -1)
            {
                result.Add(s[i]);
                answer[i] = -1;
            }
            else
            {
                answer[i] = i - result.LastIndexOf(s[i]);
                result.Add(s[i]);
            }
        }
        return answer;
    }
}