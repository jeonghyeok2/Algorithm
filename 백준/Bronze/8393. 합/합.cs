using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 1; i <= input; i++)
            {
                total += i;
            }
            Console.WriteLine(total);
        }
    }
}