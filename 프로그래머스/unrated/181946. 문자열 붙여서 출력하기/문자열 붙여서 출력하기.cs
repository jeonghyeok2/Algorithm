using System;
using System.Linq;
public class Example
{
    public static void Main()
    {
        string input = Console.ReadLine();
        input = string.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
        Console.WriteLine(input);
    }
}