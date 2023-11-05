using System;
using System.Linq;

public class Solution {
    public int solution(int[] a, int[] b) {
        int answer = a.Zip(b, (z, d) => z * d).Sum();
        return answer;
    }
}