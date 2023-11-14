using System;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] arrStr = str.Split();
            int a, b;
            a = int.Parse(arrStr[0]);
            b = int.Parse(arrStr[1]);

            Console.WriteLine(a - b);
        }
    }
}