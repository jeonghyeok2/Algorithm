using System;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(arr[0]) + int.Parse(arr[1]));
            Console.WriteLine(int.Parse(arr[0]) - int.Parse(arr[1]));
            Console.WriteLine(int.Parse(arr[0]) * int.Parse(arr[1]));
            Console.WriteLine(int.Parse(arr[0]) / int.Parse(arr[1]));
            Console.WriteLine(int.Parse(arr[0]) % int.Parse(arr[1]));
        }
    }
}
