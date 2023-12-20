using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        int index = s.Length;
        while (true) 
        {
            if (s == "1")
                break;
            int maxIndex = s.Length;
            s = s.Replace("0", string.Empty);
            answer[0]++;
            answer[1] += maxIndex - s.Length;
            s = Convert.ToString(s.Length, 2);
        }
        return answer;
    }
}