using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        for (int i = 0; i < dic.Length; i++)
        {
            for (int j = 0; j < spell.Length; j++)
            {
                if (dic[i].Contains(spell[j]))
                    dic[i] = dic[i].Remove(dic[i].IndexOf(spell[j]), 1);
                else
                    dic[i] = "No";
            }
            if (dic[i] == "")
            {
                return 1;
            }
        }
        return 2;
    }
}