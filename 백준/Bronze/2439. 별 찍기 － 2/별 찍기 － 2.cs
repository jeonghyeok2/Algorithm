using System;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int starLength = int.Parse(Console.ReadLine());
            int a = 1;
            int b = starLength - 1;
            for (int i = 0; i < starLength; i++)
            {
                for (int d = 0; d < b; d++)
                    sb.Append(" ");
                for (int j = 0; j < a; j++)
                    sb.Append("*");
                a++;
                b--;
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}