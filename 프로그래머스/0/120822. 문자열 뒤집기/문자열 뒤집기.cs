using System;

public class Solution {
    public string solution(string my_string)
    {
        string answer = Swapping(my_string);
        return answer;
    }
    public string Swapping(string my_string)
    {
        int length = my_string.Length;
        string str = "";
        for (int i = length - 1; i >= 0; i--)
        {
            str += my_string[i];
        }
        return str;
    }
}