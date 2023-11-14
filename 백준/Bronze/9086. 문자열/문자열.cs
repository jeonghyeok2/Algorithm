using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int num = int.Parse(Console.ReadLine());
            string[] arrStr = new string[num];

            for (int i = 0; i < num; i++)
            {
                arrStr[i] = Console.ReadLine();
                sb.AppendLine(arrStr[i][0].ToString() + arrStr[i][(arrStr[i].Length - 1)].ToString());;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}