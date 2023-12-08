using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        Dictionary<string, int> _category = new Dictionary<string, int>()
        {
            {"R" , 0 }, {"T" , 0  },
            {"C" , 0 }, {"F" , 0  },
            {"J" , 0 }, {"M" , 0  },
            {"A" , 0 }, {"N" , 0  }
        }; //Dictionnary에 값 저장

        for (int i = 0; i < choices.Length; i++)
        {
            string _surveyMatch = "";   //문자 저장 변수 초기화
            int _plusScore = 0;         //추가 점수 초기화
            if (choices[i] > 4)
            {
                _surveyMatch = survey[i][1].ToString();
                _plusScore = choices[i] - 4;
            }
            else
            {
                _surveyMatch = survey[i][0].ToString();
                _plusScore = 4 - choices[i];
            }
            _category[_surveyMatch] += _plusScore;
        }

        answer += _category["R"] >= _category["T"] ? "R" : "T";
        answer += _category["C"] >= _category["F"] ? "C" : "F";
        answer += _category["J"] >= _category["M"] ? "J" : "M";
        answer += _category["A"] >= _category["N"] ? "A" : "N";

        return answer;
    }
}