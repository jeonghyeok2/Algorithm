using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        DateTime _today = Convert.ToDateTime(today);
        List<int> _answer = new List<int>();

        for (int i = 0; i < privacies.Length; i++)
        {
            for (int j = 0; j < terms.Length; j++)
            {
                if (privacies[i].Contains(terms[j][0]))
                {
                    privacies[i] = privacies[i].Replace(terms[j][0], ' ');
                    DateTime _privacies = Convert.ToDateTime(privacies[i]);
                    int _addMonth = int.Parse(terms[j].Replace(terms[j][0], ' ').Trim());
                    _privacies = _privacies.AddMonths(_addMonth).AddDays(-1);

                    if (DateTime.Compare(_today, _privacies) > 0)
                    {
                        _answer.Add(i + 1);
                    }
                }
            }
        }
        return _answer.ToArray();
    }
}