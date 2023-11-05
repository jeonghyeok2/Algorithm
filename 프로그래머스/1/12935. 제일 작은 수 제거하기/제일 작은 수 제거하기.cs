using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        List<int> ints = new List<int>{};
        foreach (var item in arr)
            ints.Add(item);
        ints.Remove(arr.Min());
        if(ints.Count == 0)
            return new int[] {-1};
        return ints.ToArray();
    }
}