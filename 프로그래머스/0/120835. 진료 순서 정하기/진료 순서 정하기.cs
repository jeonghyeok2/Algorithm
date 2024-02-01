using System;

public class Solution {
    public int[] solution(int[] emergency)
    {
        int[] result = new int[emergency.Length];
        for (int j = 0; j < emergency.Length; j++)
        {
            int max = 0;
            for (int i = 0; i < emergency.Length; i++)
            {
                if (max < emergency[i])
                {
                    max = emergency[i];
                }
            }
            result[Array.IndexOf(emergency, max)] = j + 1;
            emergency[Array.IndexOf(emergency, max)] = -1;
        }
        return result;
    }
}