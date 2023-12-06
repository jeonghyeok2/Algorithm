using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        int count = (total / num) - (total % num == 0 ? num / 2 : num / 2 - 1);
        for (int i = 0; i < num; i++)
        {
            answer[i] = count;
            count++;
        }
        return answer;
    }
}