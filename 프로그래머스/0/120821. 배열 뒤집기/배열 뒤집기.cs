using System;

public class Solution {
    public int[] solution(int[] num_list)
    {
        int[] answer = Swapping(num_list);
        return answer;
    }
    public int[] Swapping(int[] num_list)
    {
        int length = num_list.Length;

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length - (i + 1); j++)
            {
                int temp = num_list[j];
                num_list[j] = num_list[j + 1];
                num_list[j + 1] = temp;
            }
        }
        return num_list;
    }
}