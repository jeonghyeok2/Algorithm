using System;
using System.Linq;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int[] ints = new int[n];
        for (int i = 0; i < n; i++) //배열을 만들어 해당하는 위치에 값 넣어주기
        {
            if (answer < section.Length && i == section[answer] - 1)
            {
                ints[i] = section[answer];
                answer++;
            }
            else
                ints[i] = 0;
        }
        answer = 0;
        for (int i = 0; i < ints.Length; i++) //칠한 부분은 0으로하고 다 칠하면 +1 해주기
        {
            if (ints[i] != 0)
            {
                for (int j = i; j < ((m + i <= ints.Length) ? m + i : ints.Length); j++)
                    ints[j] = 0;
                answer++;
            }
        }

        return answer;
    }
}