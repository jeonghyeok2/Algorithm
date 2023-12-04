using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        char[] charS = s.ToLower().ToCharArray();

        for (int i = 0; i < charS.Length; i++)
        {
            for (int j = 0; j < index; j++)
            {
                charS[i] = (char)(Convert.ToInt32(charS[i]) + 1);
                if (charS[i] > 'z')
                {
                    charS[i] = 'a';
                }
                if (skip.ToLower().Contains(charS[i]))
                {
                    j--;
                }
            }
            answer += charS[i];
        }
        return answer;
    }
}