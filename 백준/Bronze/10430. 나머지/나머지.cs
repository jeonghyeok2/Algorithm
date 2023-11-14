using System;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input  = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            if (2 <= A && A <= 10000 && 2 <= B && B <= 10000 && 
                2 <= C && C <= 10000)
            {
                Console.WriteLine((A + B) % C);
                Console.WriteLine(((A % C) + (B % C)) % C);
                Console.WriteLine((A * B) % C);
                Console.WriteLine(((A % C) * (B % C)) % C);
            }
            
        }
    }
}