using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b) {
        while(b % 2 == 0)
        {
            b /= 2;
        }
        while(b % 5 == 0)
        {
            b /= 5;
        }
        if(a % b != 0)
        {
            return 2;
        }
        return 1;
    }
}