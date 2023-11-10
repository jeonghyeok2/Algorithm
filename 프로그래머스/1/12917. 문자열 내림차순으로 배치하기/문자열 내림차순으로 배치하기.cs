public class Solution {
    public string solution(string s) {
        string answer = "";
        for (char i = 'z'; i >= 'a'; i--)
        {
            for (int d = 0; d < s.Length; d++)
            {
                if (i == s[d])
                    answer += i;
            }
        }
        for (char i = 'Z'; i >= 'A'; i--)
        {
            for (int d = 0; d < s.Length; d++)
            {
                if (i == s[d])
                    answer += i;
            }
        }
        return answer;
    }
}