using System;

public class Solution {
    public int solution(int left, int right) {
        int sum = 0;
        for (int i = left; i <= right; i++)
        {
            int count = 0;
            for (int d = 1; d <= i; d++)
            {
                if (i % d == 0)
                    count++;
            }
            if (count % 2 == 0)
                sum += i;
            else
                sum -= i;
        }
        return sum;
    }
}