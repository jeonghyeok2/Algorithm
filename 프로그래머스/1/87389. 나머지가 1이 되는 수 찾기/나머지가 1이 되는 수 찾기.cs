using System;

public class Solution 
{
    public int solution(int n)
    {
        int answer = 0;
        bool isNum = true;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 1 && isNum)
            {
                answer = i;
                isNum = false;
            }
        }
    return answer;
    }
}