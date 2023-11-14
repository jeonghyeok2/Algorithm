using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double num1 = double.Parse(input[0]);
            double num2 = double.Parse(input[1]);
            if (num1 > 0 && num2 < 10)
            {
                Console.WriteLine(num1 / num2);
            }            
        }
    }
}