using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        bool isTop = true;
        answer[1] = 100;
        for (int i = 0; i < wallpaper.Length; i++)
        {
            if (isTop && wallpaper[i].Contains("#"))
            {
                isTop = false;
                answer[0] = i;
            }
            if (answer[1] > wallpaper[i].IndexOf("#") && -1 != wallpaper[i].IndexOf("#"))
                answer[1] = wallpaper[i].IndexOf("#");
            if (wallpaper[i].Contains("#"))
                answer[2] = i + 1;
            if (answer[3] < wallpaper[i].LastIndexOf("#") + 1)
                answer[3] = wallpaper[i].LastIndexOf("#") + 1;
        }
        return answer;
    }
}