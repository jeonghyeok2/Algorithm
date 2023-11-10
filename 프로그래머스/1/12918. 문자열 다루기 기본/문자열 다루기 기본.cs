public class Solution {
    public bool solution(string s) {
        int count = 0;
        if (s.Length == 4 || s.Length == 6)
        { 
            for (int i = 0; i < s.Length; i++)
            {
                for (int d = 0; d < 10; d++)
                {
                    if (d == (int)char.GetNumericValue(s[i]))
                        count++;
                }
            }
        }
        return (s.Length == count) ? true : false;
    }
}