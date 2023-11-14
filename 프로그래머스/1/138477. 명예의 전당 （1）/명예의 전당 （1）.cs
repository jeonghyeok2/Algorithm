using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> result = new List<int>() {};
        for (int i = 0; i < score.Length; i++)
        {
            result.Add(score[i]);
            if (result.Count > k)
            {
                result.Remove(result.Min());
            }
            answer[i] = result.Min();
        }
        return answer;
    }
}