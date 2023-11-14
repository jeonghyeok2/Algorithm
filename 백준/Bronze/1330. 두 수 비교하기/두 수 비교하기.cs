using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int num1 = int.Parse(input[0]);
            int num2 = int.Parse(input[1]);

            if (num1 > num2) 
            {
                Console.WriteLine(">");
            }
            else if (num1 < num2) 
            {
                Console.WriteLine("<");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("==");
            }

        }
    }
}