using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int firstNum = commands[i, 0];
            int secondNum = commands[i, 1];
            int thirdNum = commands[i, 2];
            //1번과 2번을 빼서 + 1을 더해 배열 만들기
            int[] arrInt = new int[secondNum - firstNum + 1];
            for (int j = 0; j < arrInt.Length; j++)
                arrInt[j] = array[j + firstNum - 1];
            Array.Sort(arrInt);
            answer[i] = arrInt[thirdNum - 1];
        }
        return answer;
    }
}