using System;

public class Solution {
     public long solution(int balls, int share)
     {
         long answer = 0;
         answer = Combination(balls, share);
         return answer;
     }
     public long Combination(int balls, int share)
     {
         long sum = 1;
         for (int i = 1; i <= share; i++)
         {
             sum = (sum * balls) / i;
             balls--;
         }
         return sum;
     }
}