using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < value; i++)
        {
            for (int j = value - (i + 1); j < value; j++)
                sb.Append('*');
            sb.AppendLine();
        }
        Console.WriteLine(sb.ToString());    
    }
}