using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.Length];
        for (int i = 0; i < strings.Length; i++) 
        {   //strings문자열에 있는 문자를 앞으로 추가하기
            answer[i] = strings[i][n] + strings[i];
        }
        //문자열 정렬
        Array.Sort(answer);

        for (int i = 0; i < answer.Length; i++)
        {   //Substring으로 앞에 문자 제거
            answer[i] = answer[i].Substring(1);
        }
        return answer;
    }
}