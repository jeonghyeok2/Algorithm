using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        double temp = Math.Sqrt(n);//제곱근 구하기
        if(temp % 1 != 0)//제곱근이 1이 나와 나머지가 0이면 "정수"의 제곱이 아니다
        {
             return -1;//값 반환
        }
        answer = (long)temp + 1;
        answer *= answer;
        return answer;
    }
}