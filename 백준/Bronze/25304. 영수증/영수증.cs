using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = 0; i < N; i++)
            {
                string[] arrStr = Console.ReadLine().Split();
                int a = int.Parse(arrStr[0]);
                int b = int.Parse(arrStr[1]);
                total += a * b;
            }
            if (X == total)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}