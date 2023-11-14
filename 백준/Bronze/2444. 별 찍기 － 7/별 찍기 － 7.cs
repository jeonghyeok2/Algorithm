using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int input = int.Parse(Console.ReadLine());

            int A = input - 1; //A값에 -1을 하여 반복 한번적게하기
            int B = input * 2 - 1; // 현재 값보다 -1한 값을 주어 1, 3, 5...
            for (int i = 0; i < input; i++)
            {
                for (int j = A; j > 0; j--)
                    sb.Append(" ");
                for (int k = B; k < (input * 2); k++)
                    sb.Append("*");
                A--; //-1을 계속하여 반복줄이기
                B -= 2; //-2를 통해 반복할 양 늘리기
                sb.AppendLine();
            }
            int C = input - 2;
            int D = 0;
            for (int i = 0; i < input - 1; i++)
            {
                for (int j = C; j < input - 1; j++)
                    sb.Append(" ");
                for (int k = D; k < (input * 2) - 3; k++)
                    sb.Append("*");
                C--;
                D += 2;
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}