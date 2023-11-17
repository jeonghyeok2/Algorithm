using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] answers) {
        int[] A = { 1, 2, 3, 4, 5 };
        int[] B = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] C = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        int[] count = { 0, 0, 0 };

        for (int i = 0; i < answers.Length; i++)
        {
            if (A[i % 5] == answers[i]) { count[0] += 1; }
            if (B[i % 8] == answers[i]) { count[1] += 1; }
            if (C[i % 10] == answers[i]) { count[2] += 1; }
        }
        int max = 0;
        for (int i = 0; i < 3; i++)
        {
            if (max < count[i])
                max = count[i];
        }
        List<int> result = new List<int>();
        for (int i = 0; i < 3; i++)
        {
            if (max == count[i])
                result.Add(i + 1);
        }

        return result.ToArray();
    }
}