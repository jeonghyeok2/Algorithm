using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> list = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i; j < numbers.Length - 1; j++)
                list.Add(numbers[i] + numbers[j + 1]);
        }
        list = list.Distinct().ToList();
        list.Sort();
        int[] answer = new int[list.Count];
        answer = list.ToArray();
        return answer;
    }
}