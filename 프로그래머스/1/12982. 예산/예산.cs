using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        List<int> list = new List<int>(d);
        list.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            if (budget - list[i] < 0)
                break;
            budget -= list[i];
            answer++;
        }
        return answer;
    }
}