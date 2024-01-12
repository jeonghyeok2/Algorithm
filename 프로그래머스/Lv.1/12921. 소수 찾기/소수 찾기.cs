using System;
using System.Linq;

public class Solution {
    public int solution(int n)
    {
        int answer = 0;
        bool[] isPrime = checkPrimeNumber(n);
        for (int i = 1; i <= n; i++)
        {
            if (isPrime[i])
            {
                answer++;
            }
        }
        return answer;
    }
    public bool[] checkPrimeNumber(int n) //에라토스테네스의 체 구현
    {
        bool[] isPrime = new bool[n + 1]; //소수를 체크하기 위한 bool값

        Array.Fill(isPrime, true); //fill을 사용해 값을 다 true로 변경

        isPrime[0] = false;
        isPrime[1] = false;

        for (int i = 2; i * i <= n; i++) 
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i) //i * i 밑으로는 이미 소수 판단이 끝남 ex) 2는 소수니 4부터 시작
                {
                    isPrime[j] = false; //배수들은 다 false로 지정 ex) {4부터 시작이면 4, 6, 8...}, {9부터 시작이면 9, 12, 15...}
                }
            }
        }
        return isPrime;
    }
}