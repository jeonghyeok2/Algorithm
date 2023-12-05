using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> burger = new List<int>();
        foreach (int i in ingredient) 
        {
            burger.Add(i); //배열에값 차례대로 넣어주기
            if (burger.Count() >= 4) //리스트의 크기가 4보다 작으면 버거 X
            {   //if문으로 버거 만들어서 확인
                if (burger[burger.Count - 4] == 1 && burger[burger.Count - 3] == 2 && burger[burger.Count - 2] == 3 && burger[burger.Count - 1] == 1)
                {
                    answer++;
                    burger.RemoveRange(burger.Count() - 4, 4); //RemoveRange로 버거를 잘라주기
                }
            }
        }
        return answer;
    }
}