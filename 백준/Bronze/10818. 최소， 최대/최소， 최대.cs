using System;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxLength = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            int max = int.Parse(input[0]);
            int min = int.Parse(input[0]);

            for (int i = 0; i < maxLength; i++)
            {
                if (max <= int.Parse(input[i]))
                    max = int.Parse(input[i]);
                else if (min >= int.Parse(input[i]))
                    min= int.Parse(input[i]);
            }
            Console.WriteLine(min + " " + max);
        }
    }
}