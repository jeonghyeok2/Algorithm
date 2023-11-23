using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) 
    {
        int[] answer = new int[2];
        int _count = 0;
        int _max = 0;
        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos.Contains(win_nums[i]))
                _count++;
            if (lottos[i] == 0)
                _max++;
        }
        answer[0] = ((_count + _max == 0) ? 6 : 7 - (_count + _max));
        answer[1] = ((_count <= 1) ? 6 : 7 - _count);
        return answer;
    }
}