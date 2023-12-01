using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];

            for (int i = 0; i < targets.Length; i++)
            {
                char[] arrChar = targets[i].ToCharArray();
                for (int j = 0; j < arrChar.Length; j++)
                {
                    List<int> list = new List<int>();
                    for (int g = 0; g < keymap.Length; g++)
                    {
                        if (keymap[g].IndexOf(arrChar[j]) == -1) continue;
                        list.Add(keymap[g].IndexOf(arrChar[j]) + 1);
                    }
                    answer[i] += (list.Count == 0) ? -1000 : list.Min();
                }
            }
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = (answer[i] < 1) ? -1 : answer[i];
            }
            return answer;
    }
}