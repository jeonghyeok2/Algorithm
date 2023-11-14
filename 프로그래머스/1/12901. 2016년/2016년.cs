using System;
public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        DateTime time = new DateTime(2016, a, b);//DataTime을 이용하여 날짜 저장
        answer = time.DayOfWeek.ToString(); // 일주일에 해당하는 일을 가져옴
        answer = answer.Substring(0,3); //앞에 있는 3글자만 출력
        return answer.ToUpper();
    }
}