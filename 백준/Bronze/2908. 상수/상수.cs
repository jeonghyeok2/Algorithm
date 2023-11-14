using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            char change;
            for (int i = 0; i < 2; i++)
            {   //ToCharArray()함수를 이용하여 string형을 배열에 넣기
                char[] c = input[i].ToCharArray();
                change = c[0];
                c[0] = c[2];
                c[2] = change;
                //Tostring()함수를 이용하여 형변환 
                input[i] = c[0].ToString() + c[1] + c[2];
            }
            if (int.Parse(input[0]) > int.Parse(input[1]))
                Console.WriteLine(input[0]);
            else 
                Console.WriteLine(input[1]);
        }
    }
}