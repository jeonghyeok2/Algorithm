using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
   public string[] solution(string[] players, string[] callings)
    {
        Dictionary<string, int> playerDic = new Dictionary<string, int>();

        for (int i = 0; i < players.Length; i++)
            playerDic.Add(players[i], i);

        foreach (string item in callings)
        {   //현재 선수의 등수와 앞에있는 선수의 이름을 구함
            int rank = playerDic[item];
            string overtake = players[rank - 1];
            //현재 선수를 앞에 선수와 교체
            players[rank - 1] = item;
            players[rank] = overtake;
            //Dictionnary도 교체해주기
            playerDic[item] = rank - 1;
            playerDic[overtake] = rank;
        }

        return players;
    }
}