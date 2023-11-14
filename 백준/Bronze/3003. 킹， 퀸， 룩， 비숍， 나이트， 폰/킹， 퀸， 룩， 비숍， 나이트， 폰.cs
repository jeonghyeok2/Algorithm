using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split();
            int[] number = { 1, 1, 2, 2, 2, 8 };

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = number[i] - int.Parse(input[i]);
                sb.Append(number[i] + " ");    
            }
            Console.WriteLine(sb.ToString());
        }
    }
}