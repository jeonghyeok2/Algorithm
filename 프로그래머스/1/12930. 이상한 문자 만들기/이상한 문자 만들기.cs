public class Solution {
    public string solution(string s) 
    {
        string[] arrStr = s.Split();
        string answer = "";
        for (int i = 0; i < arrStr.Length; i++)
        {
            char[] ch = arrStr[i].ToCharArray();
            for (int j = 0; j < ch.Length; j++)
                answer += ((j % 2 == 0) ? ch[j].ToString().ToUpper() : ch[j].ToString().ToLower());
            answer += (((i + 1) == arrStr.Length) ? "" : " ");
        }
        return answer;
    }
}