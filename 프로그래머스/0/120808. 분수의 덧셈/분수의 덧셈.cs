using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        int gcdDenom = Getgcd(denom1, denom2);
        int lcmDenom = denom1 * (denom2 / gcdDenom);

        int numer = numer1 * (lcmDenom / denom1) + numer2 * (lcmDenom / denom2);
        int gcdNumer = Getgcd(numer, lcmDenom);

        numer /= gcdNumer;
        lcmDenom /= gcdNumer;

        return new int[] { numer, lcmDenom };
    }

    private int Getgcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}