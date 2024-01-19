using System;
using System.Linq;

public class Solution {
    public int solution(int[] array)
    {
        int[] answer = CenterNumber(array);
        return answer[array.Length / 2];
    }
    public int[] CenterNumber(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)   //i = 0 to N - 1
        {
            for (int j = i + 1; j < n; j++)  //j = i + 1 to N
            {
                if (array[i] > array[j])       //부등호 방향: 오름차순(>), 내림차순(<)
                {
                    int temp = array[i]; 
                    array[i] = array[j]; 
                    array[j] = temp; //SWAP
                }
            }
        }
        return array;
    }
}