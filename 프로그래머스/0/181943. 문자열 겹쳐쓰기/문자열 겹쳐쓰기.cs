using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s)
    {
        string answer = "";
        int strLength = my_string.Length;
        int overLength = overwrite_string.Length;
        for (int i = 0; i < strLength; i++)
        {
            if (i >= s && i < overLength + s)
                answer += overwrite_string[i - s];
            else
                answer += my_string[i];
        }
        return answer;
    }
}