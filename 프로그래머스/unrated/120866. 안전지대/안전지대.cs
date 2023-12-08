using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        int length = board.GetLength(0);
        int[] x = new int[8] { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] y = new int[8] { 1, 0, -1, 1, -1, 1, 0, -1 };
        int[,] temp = new int[length, length];
        int nx = 0;
        int ny = 0;

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (board[i, j] == 1)
                {
                    temp[i, j] = 1;
                    for (int k = 0; k < 8; k++)
                    {
                        nx = i + x[k];
                        ny = j + y[k];
                        if (nx >= 0 && nx < length && ny >= 0 && ny < length)
                            temp[nx, ny] = 1;
                    }
                }
            }
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (temp[i, j] != 1)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}