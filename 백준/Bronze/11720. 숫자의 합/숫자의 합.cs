using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < input; i++)
                sum += int.Parse(numbers[i].ToString());
            Console.WriteLine(sum);
        }
    }
}