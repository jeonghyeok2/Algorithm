using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            Console.WriteLine(num1 * int.Parse(input[2].ToString()));
            Console.WriteLine(num1 * int.Parse(input[1].ToString()));
            Console.WriteLine(num1 * int.Parse(input[0].ToString()));
            Console.WriteLine(num1 * int.Parse(input));
        }
    }
}