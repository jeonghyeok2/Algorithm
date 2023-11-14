using System;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int X = int.Parse(input[1]);

            string[] value = Console.ReadLine().Split();

            for (int i = 0; i < N; i++)
            {
                if (int.Parse(value[i]) < X)
                    sb.Append(value[i] + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}