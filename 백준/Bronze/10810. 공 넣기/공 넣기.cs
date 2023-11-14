using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int[] num = new int[N];

            for (int i = 0; i < M; i++)
            {
                string[] str = Console.ReadLine().Split();
                for (int j = int.Parse(str[0]) - 1; j <= int.Parse(str[1]) - 1; j++)
                    num[j] = int.Parse(str[2]);
            }
            foreach (int i in num)
                stringBuilder.Append(i + " ");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}