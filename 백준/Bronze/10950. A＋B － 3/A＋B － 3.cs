using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string[] arrStr = Console.ReadLine().Split();
                int a = int.Parse(arrStr[0]);
                int b = int.Parse(arrStr[1]);

                Console.WriteLine(a + b);
            }
        }
    }
}