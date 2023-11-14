using System;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            do
            {
                string input = Console.ReadLine();
                if (input == null)
                    break;
                string[] strSplit = input.Split(); 
                int a = int.Parse(strSplit[0]);
                int b = int.Parse(strSplit[1]);
                sb.AppendLine((a + b).ToString());
            } while (true);
            
            Console.WriteLine(sb.ToString());   
        }
    }
}