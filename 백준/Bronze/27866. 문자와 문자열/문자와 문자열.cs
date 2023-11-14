using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(str[num - 1]);
        }
    }
}