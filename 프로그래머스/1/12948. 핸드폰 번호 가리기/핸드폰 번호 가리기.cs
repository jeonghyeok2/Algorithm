public class Solution {
    public string solution(string phone_number) {
        char[] chars = phone_number.ToCharArray();
        string answer = "";
        for (int i = 0; i < (phone_number.Length - 4); i++)
                chars[i] = char.Parse("*");
        foreach (char c in chars) 
                answer += c;
        return answer;
    }
}