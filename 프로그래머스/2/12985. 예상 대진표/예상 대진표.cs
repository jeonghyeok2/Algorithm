using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;
        int count = 1;
        for (int i = 0; i < n; i++)
        {
            if ((a % 2 == 0 && a - 1 == b) || ( a % 2 != 0 && a + 1 == b))
            {
                return count;
            }
            a = a % 2 != 0 ? (a + 1) / 2 : a = a / 2;
            b = b % 2 != 0 ? (b + 1) / 2 : b = b / 2;
            count++;
        }
        return answer;
    }
}