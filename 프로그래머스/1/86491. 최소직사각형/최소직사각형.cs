using System;

public class Solution {
    public int solution(int[,] sizes) {
        int width = 0;
        int height = 0;
        int temp = 0;
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            for (int j = 0; j < sizes.GetLength(1); j++)
            {
                if (sizes[i, 0] <= sizes[i, 1])
                {
                    temp = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = temp;
                }
                if (sizes[i,0] > width)
                    width = sizes[i, 0];
                if (sizes[i,1] > height)
                    height = sizes[i,1];
            }
        }
        return width * height;
    }
}