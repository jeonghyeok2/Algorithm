using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s)
    {
        int answer = 0;
        List<char> str = new List<char> (s);
        for (int i = 0; i < s.Length; i++)
        {
            answer += Check(str) ? 1 : 0;
            str.Add(str[0]);
            str.RemoveAt(0);    
        }
        return answer;
    }
    private bool Check(List<char> s)
    {
        Stack<char> stack = new Stack<char>();
        string open = "([{";
        string close = ")]}";

        for (int j = 0; j < s.Count; j++)
        {
            if (open.Contains(s[j])) //문자열에 값이 괄호의 앞인지 확인하고 값 담기
            {
                stack.Push(s[j]);
            }
            else //괄호의 뒷부분
            {
                if (stack.Count == 0) //조건이 맞지 않아 false
                {
                    return false;
                }
                if (s[j] != close[open.IndexOf(stack.Peek())]) //먼저 들어온 앞부분과 괄호가 같지 않으면 false
                {
                    return false;
                }
                stack.Pop();
            }
        }
        if (stack.Count != 0)
        {
            return false;
        }
        return true;
    }
}