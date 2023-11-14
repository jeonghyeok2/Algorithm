using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] number = { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

            char[] chars = Console.ReadLine().ToCharArray();
            int total = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                int second = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    ++second;
                    if (number[j].Contains(chars[i]))
                        total += second + 2;
                }
            }
            Console.WriteLine(total);
        }
    }
}