using System;

public class Solution {
    public string solution(string my_string, string letter)
    {
        string answer = "";
        int strLength = my_string.Length;
        for (int i = 0; i < strLength; i++)
        {
            if (my_string[i] != letter[0])
                answer += my_string[i];
        }
        return answer;
    }
}