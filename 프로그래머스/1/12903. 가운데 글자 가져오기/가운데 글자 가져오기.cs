public class Solution {
    public string solution(string s) {
        string answer = "";
        int ints = 0;
        if (s.Length % 2  == 0)
        {
            ints = (s.Length / 2) - 1;
            return answer = s[ints].ToString() + s[ints + 1];
        }
        else
        {
            ints = s.Length / 2;
            return answer = s[ints].ToString();
        }
    }
}