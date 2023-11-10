using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        for (int i = 0; i < b; i++) 
        {
            for (int d = 0; d < a; d++)
                sb.Append("*");
            sb.AppendLine();
        }
        Console.WriteLine(sb.ToString());
    }
}