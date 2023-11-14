using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            int total = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    total++;
            }
            if (input.Length == 0)
                Console.WriteLine(0);
            else
                Console.WriteLine(total + 1);
        }
    }
}