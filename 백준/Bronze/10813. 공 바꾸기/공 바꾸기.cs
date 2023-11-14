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
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[] arrInt = new int[n];
            for (int i = 0; i < n; i++)
                arrInt[i] = i + 1;

            int change;
          
            for (int i = 0; i < m; i++)
            {
                string[] str = Console.ReadLine().Split();
                change = arrInt[(int.Parse(str[0]) - 1)];
                arrInt[(int.Parse(str[0]) - 1)] = arrInt[(int.Parse(str[1]) - 1)];
                arrInt[(int.Parse(str[1]) - 1)] = change;
            }
            foreach (int str in arrInt) 
                sb.Append(str + " ");
            Console.WriteLine(sb.ToString());
        }
    }
}