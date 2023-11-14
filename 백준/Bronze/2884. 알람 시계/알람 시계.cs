using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int hour = int.Parse(input[0]);
            int minute = int.Parse(input[1]);

            if (0 <= hour && hour <= 23 && 0 <= minute  && minute <= 59)
            {
                if ((minute - 45) < 0)
                {
                    if (hour == 0)
                    {
                        hour = 23;
                        Console.WriteLine(hour + " " + (60 + (minute - 45)));
                    }
                    else 
                    {
                        Console.WriteLine((hour - 1) + " " + (60 + (minute - 45)));
                    }
                }
                else
                    Console.WriteLine(hour + " " + (minute - 45));
            }
        }
    }
}