using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        while (n > a - 1) 
        {
            answer += n / a * b; // 병을 콜라로 바꾼 고 주는 병 곱해주기
            n = (n / a) * b + n % a; //콜라로 바꾸고 남은 병 + 
        }
        return answer;
    }
}