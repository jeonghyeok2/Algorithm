namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputReverse = new string(input.Reverse().ToArray());

            if (input == inputReverse)
                Console.WriteLine("1");
            else 
                Console.WriteLine("0");
        }
    }
}