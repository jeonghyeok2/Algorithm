public class Solution {
    public int solution(int[] arr)
    {
        int answer = lcm(arr[0], arr[1]);

        for (int i = 2; i < arr.Length; i++)
        {
            answer = lcm(answer, arr[i]);
        }
        return answer;
    }
    //유클리드 호제법

    //최대 공약수
    public int gcd(int a, int b)
    {
        while (b != 0)
        {
            var temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }

    //최소 공배수 
    public int lcm(int a, int b)
    {
        return (int)a * b / gcd(a, b);
    }
}