using System;

public class Solution {
    public int solution(int[,] dots)
    {
        int answer = 0;
        if (Check(dots, 0, 1, 2, 3))
            return 1;
        else if (Check(dots, 0, 2, 1, 3))
            return 1;
        else if (Check(dots, 0, 3, 1, 2))
            return 1;

        return answer;
    }
    public bool Check(int[,] dots, int X1, int X2, int X3, int X4)
    {
        if (dots[X2, 0] - dots[X1, 0] == 0 && dots[X4, 0] - dots[X3, 0] == 0) return true;
        if (dots[X2, 0] - dots[X1, 0] == 0 || dots[X4, 0] - dots[X3, 0] == 0) return false;

        float slope1 = (float)(dots[X2, 1] - dots[X1, 1]) / (dots[X2, 0] - dots[X1, 0]);
        float slope2 = (float)(dots[X4, 1] - dots[X3, 1]) / (dots[X4, 0] - dots[X3, 0]);

        return slope1 == slope2;
    }
}