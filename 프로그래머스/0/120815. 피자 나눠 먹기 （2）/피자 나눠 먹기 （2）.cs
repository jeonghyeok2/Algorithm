using System;

public class Solution {
    public int solution(int n)
    {
        int pizza = 6;
        int count = 0;
        while (true) 
        {
            count++;
            if (pizza % n == 0)
                break;
            pizza += 6;
        }
        return count;
    }
}