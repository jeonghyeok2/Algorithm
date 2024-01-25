using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] answer = new int[num2 - num1 + 1];
        int index = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i >= num1 && num2 >= i)
            {
                answer[index] = numbers[i];
                index++;
            }
        }
        return answer;
    }
}