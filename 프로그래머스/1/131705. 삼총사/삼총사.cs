using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        for (int i = 0; i < number.Length; i++) //시작 번호
        {
            for (int j = i + 1; j < number.Length; j++)//시작 번호와 2번이 겹치지 않게
            {
                for (int h = j + 1; h < number.Length; h++)//2번과 3번이 겹치지 않게
                {
                    if (number[i] + number[j] + number[h] == 0)
                        answer++;
                }
            }
        }
        return answer;
    }
}