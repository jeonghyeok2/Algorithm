using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(input + " * " + i + " = " +(input * i));
            }
        }
    }
}