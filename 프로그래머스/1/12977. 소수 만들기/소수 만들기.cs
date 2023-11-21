using System;
using System.Collections.Generic;
class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        List<int> list = new List<int>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int h = j + 1; h < nums.Length; h++)
                {
                    list.Add(nums[i] + nums[j] + nums[h]);
                }
            }
        }
        foreach (int i in list) 
        {
            int count = 0;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                    count++;
            }
            answer += (count == 0) ? 1 : 0;
        }
        return answer;
    }
}