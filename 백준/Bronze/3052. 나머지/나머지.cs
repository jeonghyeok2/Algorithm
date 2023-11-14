using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int[] num = new int[10];
            bool[] isNum = new bool[42];
            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine()) % 42;
                isNum[num[i]] = true;
            }
            for (int i = 0; i < isNum.Length; i++)
            {
                if (isNum[i] == true)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}