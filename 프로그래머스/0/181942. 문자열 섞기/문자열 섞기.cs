using System;

public class Solution {
    public string solution(string str1, string str2) {
        string answer = "";
        int length = str1.Length;
        for (int i = 0; i < length; i++)
        {
            answer += str1[i];
            answer += str2[i];
        }
        return answer;
    }
}