using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine)
    {
         int answer = 0;
         int total = 0;

         var fruitCounts = tangerine
             .GroupBy(x => x) //같은 과일끼리 그룹화 하기
             .Select(group => new { Fruit = group.Key, Count = group.Count() }) //새로운 컬렉션 생성 
             .OrderByDescending(x => x.Count) //내림차순 정렬
             .ToList();

         foreach (var item in fruitCounts)
         {
             total += item.Count;
             answer++;
             if (total >= k)
             {
                 break;
             }
         }
         return answer;
    }
}