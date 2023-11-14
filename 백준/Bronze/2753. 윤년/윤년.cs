using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (1 <= year && year <= 4000)
            {
                if (year % 4 == 0 && year % 100 != 0)
                        Console.WriteLine("1");
                else if (year % 400 == 0)
                        Console.WriteLine("1");
                else              
                    Console.WriteLine("0"); 
            }
        }
    }
}