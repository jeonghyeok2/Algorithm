using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int index = 0;

        for (int i = 0; i < k - 1; i++)
            index += 2;

        answer = numbers[index % numbers.Length];
        return answer;
    }
}