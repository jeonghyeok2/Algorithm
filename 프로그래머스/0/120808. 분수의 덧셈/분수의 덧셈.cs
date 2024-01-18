using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        int[] answer = new int[2];

        int lcm = denom1 * denom2 / Getgcd(denom1, denom2);
        answer[0] = numer1 * (lcm / denom1) + numer2 * (lcm / denom2);
        answer[1] = lcm;
        int gcd = Getgcd(answer[0], answer[1]);

        answer[0] /= gcd;
        answer[1] /= gcd;

        foreach (int i in answer)
        {
            Console.WriteLine(i);
        }
        return answer;
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