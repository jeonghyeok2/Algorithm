using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        string ageStr = age.ToString();

        foreach (char number in ageStr)
        {
            // '0'에서 '9'까지의 ASCII 값을 'a'에서 'j'로 매핑합니다.
            answer += (char)('a' + (number - '0'));
        }

        return answer;
    }
}