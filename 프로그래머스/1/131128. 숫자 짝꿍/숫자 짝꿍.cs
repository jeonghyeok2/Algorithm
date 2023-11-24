using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y)
    {
    string answer = "";
//0 ~ 10 까지 몇개씩 들어있는지 확이하기 위한 배열
int[] xArray = new int[10]; 
int[] yArray = new int[10];

for (int i = 0; i < 10; i++)
{
    xArray[i] = X.Length - X.Replace(i.ToString(), string.Empty).Length; //X의 0 ~ 9까지 i 값이 몇개 들어갔는지 확인
    yArray[i] = Y.Length - Y.Replace(i.ToString(), string.Empty).Length; //Y의 0 ~ 9까지 i 값이 몇개 들어갔는지 확인
}

for (int i = 9; i >= 0; i--)
{
    if (xArray[i] == 0 || yArray[i] == 0)
    {
        continue;
    }
    int min = Math.Min(xArray[i], yArray[i]);

    answer += string.Concat(Enumerable.Repeat(i.ToString(), min));
}
int intAnswer;
int.TryParse(answer, out intAnswer);
if (answer.Length == 0)
    return "-1";
else if (answer.Replace("0","").Length == 0)
    return "0";
else
    return answer;
    }
}