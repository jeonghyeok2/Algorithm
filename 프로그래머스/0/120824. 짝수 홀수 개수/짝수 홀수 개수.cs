using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2];
        int Length = num_list.Length;
        for (int i = 0; i < Length; i++)
        {
            if (num_list[i] % 2 == 0)
                answer[0] += 1;
            else
                answer[1] += 1;
        }
        return answer;
    }
}