using System;

public class Example
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        Console.WriteLine($"{s[0]} + {s[1]} = {int.Parse(s[0]) + int.Parse(s[1])}");
    }
}