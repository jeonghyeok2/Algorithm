using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        Array.Sort(lost);
        Array.Sort(reserve);

        //체육복을 잃어버린 학생
        foreach(int i in lost) 
        {   //체육복을 여벌로 챙겨온 학생
            foreach (int j in reserve)
            {   //여벌로 챙겨온 학생이 도둑맞으면
                if (j == i)
                {
                    lost = lost.Where(x => x != i).ToArray(); //현재 i값 삭제 후 저장
                    reserve = reserve.Where(x => x != j).ToArray();//현재 j값 삭제 후 저장
                }
            }
        }

        int count = 0;

        foreach (int i in lost)
        {
            for (int j = 0; j < reserve.Length; j++)
            {   // 잃어버린 학생의 앞 뒤로 여벌옷을 가져온 사람이 있는지 확인 그리고 reserve의 값이 0이면 이미 빌려준거임
                if (i -  1 == reserve[j] && reserve[j] != 0 || i + 1 == reserve[j] && reserve[j] != 0)
                {
                    reserve[j] = 0;
                    count++;
                    break;
                }
            }
        }

        return n - lost.Length + count;
    }
}