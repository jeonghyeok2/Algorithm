using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string str = n.ToString();
        for (int i = 0; i < str.Length; i++)
        {
            answer += (int)char.GetNumericValue(str[i]);
        }
        return answer;
    }
}