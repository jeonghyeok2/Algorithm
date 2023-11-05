public class Solution {
    public string solution(string s) {
        int n = (s.Length + 1) % 2; //홀수 = 0이 나와야 하므로 +1 해서 나머지 구하기
        int l = (s.Length / 2) - n;
        return s.Substring(l,n + 1);
    }
}