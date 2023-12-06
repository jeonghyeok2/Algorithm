using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] bab = { "aya", "ye", "woo", "ma" };

        for (int i = 0; i < babbling.Length; i++)
        {
            for (int j = 0; j < bab.Length; j++)
            {
                if (babbling[i].Contains(bab[j]))
                    babbling[i] = babbling[i].Replace(bab[j], " ");
            }
        }
        foreach (string item in babbling)
        {
            if (item.Trim() == "")
                answer++;
        }
        return answer;
    }
}