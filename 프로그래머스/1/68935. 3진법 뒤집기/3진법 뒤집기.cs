using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> list = new List<int>();
        int sum = 0;
        int sqrt = 1;
        while (n != 0) 
        {   
            list.Add(n % 3); //3의 나머지를 넣는다
            n = n / 3; // n의 값을 3으로 나누고 저장
        }
        list.Reverse();
        for (int i = 0; i < list.Count; i++)
                sum += list[i] * ((i == 0) ? 1 : sqrt *= 3);
        return sum;
    }
}