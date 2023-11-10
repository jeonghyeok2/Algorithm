using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        List<string> list = new List<string>();
        for (int i = 0; i < t.Length - (p.Length - 1); i++)//p의 크기만큼 배열을 만들어야 하니 p의 크기에 -1
        {
            string test = "";
            for (int j = 0; j < p.Length; j++)
                test += t[i+j].ToString();//i + j를 이용해 i번부터 p의 크기만큼 번호 저장 
            list.Add(test);
        }
        for (int i = 0; i < list.Count; i++)
        {
            if (long.Parse(list[i]) <= long.Parse(p))//리스트에 닮긴 내용을 조건과 일치하는지 확인 후 ++
                answer++;
        }
        return answer;
    }
}