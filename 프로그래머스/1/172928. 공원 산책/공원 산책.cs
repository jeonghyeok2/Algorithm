using System;

public class Solution {
     public int[] solution(string[] park, string[] routes)
     {
         int[] answer = StartPosition(park);
         int width = park[0].Length;
         int height = park.Length;
         for (int i = 0; i < routes.Length; i++)
         {
             char direction = routes[i][0];
             int moveValue = MoveValue(routes[i]);

             int tempX = answer[1];
             int tempY = answer[0];

             switch (direction)
             {
                 case 'E':
                     tempX += moveValue;
                     break;
                 case 'S':
                     tempY += moveValue;
                     break;
                 case 'W':
                     tempX -= moveValue;
                     break;
                 case 'N':
                     tempY -= moveValue;
                     break;
             }
             if (tempX < width && tempX >= 0 && tempY < height && tempY >= 0)
             {
                 bool check = true;
                 if (tempX > answer[1])
                 {
                     for (int j = answer[1]; j <= tempX; j++)
                     {
                         if (park[answer[0]][j] == 'X')
                         {
                             check = false;
                             break;
                         }
                     }
                 }
                 else if (tempX < answer[1])
                 {
                     for (int j = tempX; j <= answer[1]; j++)
                     {
                         if (park[answer[0]][j] == 'X')
                         {
                             check = false;
                             break;
                         }
                     }
                 }
                 else if (tempY > answer[0])
                 {
                     for (int j = answer[0]; j <= tempY; j++)
                     {
                         if (park[j][answer[1]] == 'X')
                         {
                             check = false;
                             break;
                         }
                     }
                 }
                 else if (tempY < answer[0])
                 {
                     for (int j = tempY; j <= answer[0]; j++)
                     {
                         if (park[j][answer[1]] == 'X')
                         {
                             check = false;
                             break;
                         }
                     }
                 }
                 if (check == true)
                 {
                     answer[1] = tempX;
                     answer[0] = tempY;
                 }
             }
         }
         answer = new int[2] { answer[0], answer[1] };
         foreach (int i in answer)
         {
             Console.WriteLine(i);
         }
         return answer;
     }
     public int[] StartPosition(string[] park)
     {
         int[] answer = new int[2];
         for (int i = 0; i < park.Length; i++)
         {
             if (park[i].Contains("S"))
             {
                 answer[0] = i;
                 answer[1] = park[i].IndexOf("S");
             }
         }
         return answer;
     } //시작위치 함수
     public int MoveValue(string route)
     {
         return (int)char.GetNumericValue(route[route.Length - 1]);
     } //이동할 값 전달
}