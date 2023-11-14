using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (1000 <= num && num <= 3000)
            {
                Console.WriteLine(num - 543);
            }            
        }
    }
}