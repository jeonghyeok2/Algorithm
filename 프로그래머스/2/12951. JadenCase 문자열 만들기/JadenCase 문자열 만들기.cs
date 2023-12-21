public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] arrCh = s.ToLower().ToCharArray();
        for (int i = 0; i < arrCh.Length; i++)
        {
            if (i == 0)
            {
                arrCh[i] = char.ToUpper(arrCh[i]);
            }
            else if (arrCh[i - 1] == ' ')
            {
                arrCh[i] = char.ToUpper(arrCh[i]);
            }
        }
        foreach (var item in arrCh)
        {
            answer += item.ToString();
        }
        return answer;
    }
}