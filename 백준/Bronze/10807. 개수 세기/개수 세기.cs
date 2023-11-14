using System;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrNum = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int v = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < arrNum; i++)
            {
                if (v == int.Parse(input[i]))
                    total++;
            }
            Console.WriteLine(total);
        }
    }
}