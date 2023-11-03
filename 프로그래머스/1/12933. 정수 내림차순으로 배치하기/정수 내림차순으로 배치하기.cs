using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        char[] chArr = n.ToString().ToCharArray();
        Array.Sort(chArr);
        Array.Reverse(chArr);
        string a = null;
        foreach (char ch in chArr) 
            a += ch;    
        return long.Parse(a);
    }
}