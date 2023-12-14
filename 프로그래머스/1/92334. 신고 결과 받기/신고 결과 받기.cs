using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        report = report.Distinct().ToArray();

        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

        foreach (var item in id_list)
        {
            keyValuePairs.Add(item, 0);
        }

        for (int j = 0; j < report.Length; j++)
        {
            string[] strings = report[j].Split(' ');
            keyValuePairs[strings[1]] += 1;
        }
        for (int j = 0; j < report.Length; j++)
        {
            string[] strings = report[j].Split(' ');
            if (keyValuePairs[strings[1]] >= k)
            {
                answer[Array.IndexOf(id_list, strings[0])] += 1;
            }
        }
        return answer;
    }
}