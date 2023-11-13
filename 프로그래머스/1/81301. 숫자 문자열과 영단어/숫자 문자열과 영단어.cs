using System;

public class Solution {
    public int solution(string s) {
        string[] numbers = { "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        for (int i = 0; i < numbers.Length; i++)
            s = s.Replace(numbers[i],$"{i}");
        int answer = int.Parse(s);
        return answer;
    }
}