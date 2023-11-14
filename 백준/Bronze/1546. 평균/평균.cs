using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split();
            double[] arrNum = new double[input];

            float max = float.Parse(num[0]);
            double sum = 0;

            for (int i = 0; i < input; i++)
            {
                if (max < float.Parse(num[i]))
                    max = float.Parse(num[i]);
            }
            for (int i = 0; i < input; i++)
            {
                arrNum[i] = double.Parse(num[i]) / max * 100;
                sum += arrNum[i];
            }   
            Console.WriteLine(sum / input);
        }
    }
}