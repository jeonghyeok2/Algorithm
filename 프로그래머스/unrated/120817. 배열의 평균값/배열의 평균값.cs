using System;

public class Solution {
    public double solution(int[] numbers) {
        double avg = 0;
        foreach (int n in numbers)
            avg += n;
        avg = avg / numbers.Length;
        return avg;
    }
}