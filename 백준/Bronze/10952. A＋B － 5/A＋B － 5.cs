using System;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            bool boo = true;

            do
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                if (a == 0 && b == 0)
                    break;
                sb.AppendLine((a + b).ToString());
            } while (boo);
            
            Console.WriteLine(sb.ToString());   
        }
    }
}