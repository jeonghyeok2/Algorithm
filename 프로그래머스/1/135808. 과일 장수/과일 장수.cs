using System.Linq;
using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0; //이익의 총합
        Array.Sort(score); //상저 정렬
        Array.Reverse(score); // 높은 값을 앞으로 보내기
        int index = m - 1;
        //상자를 만들 수 있을만큼만 반복
        for (int j = 0; j < score.Length / m; j++)
        {   //총합을 각 상자의 제일 끝에있는 작은값에  * m을해줌
            answer += score[index] * m;
            index += m; //그 다음 상자에 접근하기
        }
        return answer;       
    }
}