using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int x, y;
        int width = brown + yellow;
        for (int i = 1; i <= width; i++)
        {
            x = i;
            y = width / x;
            if (x >= y)
            {   //x = 위, 아래 크기 y = 왼쪽, 오른쪽 크기 x,y의 중복을 없애기 위해 -4
                if (width - ((x * 2) + (y * 2) - 4) == yellow)
                {
                    answer[0] = x;
                    answer[1] = y;
                    break;
                }
            }
        }
        return answer;
    }
}