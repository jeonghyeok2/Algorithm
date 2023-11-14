using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int plusMinute = int.Parse(Console.ReadLine());
            int hour = int.Parse(input[0]);
            int minute = int.Parse(input[1]);
 
            if (0 <= hour && hour <= 23 && 0 <= minute  && minute <= 59)
            {
                int sum = plusMinute + minute;
                hour = sum / 60 + hour;
                minute = sum % 60;

                if (hour >= 24)
                    Console.WriteLine((hour - 24) + " " + minute);
                else
                    Console.WriteLine(hour + " " + minute);
            }
        }
    }
}