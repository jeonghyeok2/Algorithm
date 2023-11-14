using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        for (int i = 1; i < food.Length; i++)
        {
            for (int j = 1; j <= food[i] / 2; j++)
            {
                answer += i;
            }
        }
        answer = answer + "0"+  new string(answer.Reverse().ToArray());
        return answer;
    }
}