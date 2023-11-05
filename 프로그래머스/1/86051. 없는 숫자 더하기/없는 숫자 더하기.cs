using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        foreach(var item in numbers)
            answer += item;
        answer = 45 - answer;
        return answer;
    }
}