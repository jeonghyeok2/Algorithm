using System;

public class Solution {
    public int solution(int slice, int n)
    {
        int pizza = n / slice;
        if (n - pizza * slice != 0)
        {
            pizza++;
        }
        return pizza;
    }
}