using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Enumerable.Range(1, 30).ToList();
            for (int i = 0; i < 28; i++)
            {
                int n = int.Parse(Console.ReadLine());
                number.Remove(n);
            }
            number.Sort();
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
        }
    }
}