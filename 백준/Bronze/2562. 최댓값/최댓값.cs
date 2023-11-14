using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = new int[9];
            int max = 0;
            int maxNum = 0;

            for (int i = 0; i < 9; i++)
                arrInt[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < 9; i++)
            {
                if (max <= arrInt[i])
                {
                    max = arrInt[i];
                    maxNum = i + 1;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(maxNum);
        }
    }
}