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
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string[] str = Console.ReadLine().Split();
                int num = int.Parse(str[0]);
                string str1 = str[1];
                for (int g = 0; g < str1.Length; g++)
                {
                    for (int f = 0; f < num; f++)
                        sb.Append(str1[g]);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}