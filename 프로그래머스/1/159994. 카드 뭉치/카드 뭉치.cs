using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int cardIndex1 = 0;
        int cardIndex2 = 0;
        for (int i = 0; i < goal.Length; i++)
        {
            if (cardIndex1 != cards1.Length && goal[i] == cards1[cardIndex1])
            {
                cardIndex1++;
                continue;
            }
            else if (cardIndex2 != cards2.Length && goal[i] == cards2[cardIndex2])
            {
                cardIndex2++;
                continue;
            }
            else
                return "No";
        }
        return "Yes";
    }
}