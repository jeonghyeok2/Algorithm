using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= 0 && input <= 100) 
            { 
                if (input >= 90)
                    Console.WriteLine("A");
                else if (input >= 80)
                    Console.WriteLine("B");
                else if (input >= 70)
                    Console.WriteLine("C");
                else if (input >= 60)
                    Console.WriteLine("D");
                else
                    Console.WriteLine("F");
            }

        }
    }
}