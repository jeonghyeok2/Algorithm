using System;

public class Solution {
    public string solution(string my_string, int n)
    {
        string answer = "";
        int strLength = my_string.Length;
        for (int i = 0; i < strLength; i++)
        {
            for (int j = 0; j < n; j++)
                answer += my_string[i];
        }
        return answer;
    }
}