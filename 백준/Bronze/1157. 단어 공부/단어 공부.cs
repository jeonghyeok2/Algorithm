using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine().ToUpper();
            char[] ch = input.ToCharArray();
            Array.Sort(ch);
            int max = 0;
            int count = 0;
            char str = 'a';
            bool isTrue = false;

            for (char i = 'A'; i <= 'Z'; i++) 
            {
                for (int d = 0; d < input.Length; d++)
                {
                    if (i == input[d])
                        count++;
                }
                if (count > max)
                {
                    max = count;
                    str = i;
                    isTrue = false;
                }
                else if (count == max)
                {
                    isTrue = true;
                }
                count = 0;//count초기화
            }

            if (isTrue)
            {
                Console.WriteLine("?");
            }
            else
                Console.WriteLine(str.ToString());
        }
    }
}