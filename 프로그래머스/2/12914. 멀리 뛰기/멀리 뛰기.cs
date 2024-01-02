public class Solution {
    public long solution(int n)
    {
        long answer =  fibo(n) % 1234567;
        return answer;
    }
    public long fibo(int n)
    {
        if (n == 1 || n == 0)
        {
            return (n == 1) ? 1 : 0;
        }
        long first = 1;
        long second = 1;
        long result = 1;

        for (int i = 0; i <= n - 2; i++)
        {
            first = second;
            second = result;
            result = (long) (first + second) % 1234567;
        }
        return result;
    }
}