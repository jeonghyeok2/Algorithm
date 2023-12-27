using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int[] arrInt = new int[1000];
        bool isBool = true;
        for (int i = 0; i < array.Length; i++)
        {
            arrInt[array[i]]++;
        }
        for (int i = 0; i < 1000; i++)
        {
            if (arrInt[i] == arrInt.Max() && isBool)
            {
                answer = i;
                isBool = false;
            }
            else if (arrInt[i] == arrInt.Max() && !isBool)
            {
                return -1;
            }
        }
        return answer;
    }
}