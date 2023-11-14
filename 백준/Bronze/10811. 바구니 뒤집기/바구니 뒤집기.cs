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
            string[] nm = Console.ReadLine().Split();
            int[] num = new int[int.Parse(nm[0])];
            int change;

            for (int i = 0; i < int.Parse(nm[0]); i++)
                num[i] = i + 1;
            for (int i = 0; i < int.Parse(nm[1]); i++)
            {
                string[] ij = Console.ReadLine().Split();
                int A = int.Parse(ij[0]) - 1;
                int B = int.Parse(ij[1]) - 1;

                while (B > A)
                {
                    change = num[A];
                    num[A] = num[B];
                    num[B] = change;
                    A++;
                    B--;
                }
            }
            foreach (int i in num)
                sb.Append(i + " ");
            Console.WriteLine(sb.ToString());
        }
    }
}