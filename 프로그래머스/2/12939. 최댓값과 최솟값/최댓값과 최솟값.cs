using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int[] ints = Array.ConvertAll(s.Split(' '), int.Parse);
        answer = $"{ints.Min()} {ints.Max()}";
        return answer;
    }
}