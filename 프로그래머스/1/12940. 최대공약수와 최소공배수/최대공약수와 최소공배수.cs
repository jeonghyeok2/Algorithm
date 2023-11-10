public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int max = 0;
        int min = 0;
        for (int i = 1; i <= ((n > m) ? n : m); i++)
        {
            if (n % i == 0 && m % i == 0)
                max = i;
        }
        min = (n * m) / max; //최소공배수는 두 수를 곱하고 최대공약수로 나누면 된다.
        answer[0] = max;
        answer[1] = min;
        return answer;
    }
}