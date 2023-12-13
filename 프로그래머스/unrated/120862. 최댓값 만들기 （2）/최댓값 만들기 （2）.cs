using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        List<int> _minusList = new List<int>();
        List<int> _plusList = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] <= 0)
            {
                _minusList.Add(numbers[i]);
            }
            else
            {
                _plusList.Add(numbers[i]);
            }
        }
        _minusList.Sort();
        _plusList.Sort();

        if (_minusList.Count >= 2 && _plusList.Count >= 2)
        {
            _minusList[_minusList.Count - 1] *= _minusList[_minusList.Count - 2];
            _plusList[_plusList.Count - 1] *= _plusList[_plusList.Count - 2];
            answer = (_minusList[_minusList.Count - 1] >= _plusList[_plusList.Count - 1]) ? _minusList[_minusList.Count - 1] : _plusList[_plusList.Count - 1];
        }
        else if (_minusList.Count == 1 && _plusList.Count == 1)
        {
            answer = _minusList[_minusList.Count - 1] * _plusList[_plusList.Count - 1];
        }
        else if (_minusList.Count >= 2 && _plusList.Count == 0)
        {
            answer = _minusList[_minusList.Count - 1] * _minusList[_minusList.Count - 2];
        }
        else if (_plusList.Count >= 2 && _minusList.Count == 0)
        {
            answer = _plusList[_plusList.Count - 1] * _plusList[_plusList.Count - 2];
        }
        return answer ;
    }
}