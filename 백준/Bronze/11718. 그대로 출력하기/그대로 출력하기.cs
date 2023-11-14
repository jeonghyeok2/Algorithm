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

            while (true) 
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) 
                    break;
                sb.AppendLine(input);
            }
            Console.WriteLine (sb.ToString());
        }
    }
}