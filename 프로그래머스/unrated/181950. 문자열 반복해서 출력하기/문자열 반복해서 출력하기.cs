using System;

public class Example
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < int.Parse(input[1]); i++) 
            Console.Write(input[0]);
    }
}