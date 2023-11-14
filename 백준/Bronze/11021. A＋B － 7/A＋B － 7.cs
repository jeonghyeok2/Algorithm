using System;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int max = int.Parse(Console.ReadLine());
            int[] a = new int[max];
            int[] b = new int[max];

            for (int i = 0; i < max; i++)
            {
                string[] input = Console.ReadLine().Split();
                a[i] = int.Parse(input[0]);
                b[i] = int.Parse(input[1]);

                sb.Append("Case #" + (i + 1) + ": " + (a[i] + b[i]) + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}