using System;

public class Solution {
    public int solution(int n)
    {
        int answer = n / 7;
        if (n - answer * 7 != 0)
        {
            answer += 1;
        }
        return answer;
    }
}