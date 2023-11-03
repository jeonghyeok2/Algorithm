using System;

public class Example
{
    public static void Main()
    {
        string input = Console.ReadLine();
        char[] chArr = input.ToCharArray();
        input = null;
        for (int i = 0; i < chArr.Length; i++)
        {
            if (Char.IsUpper(chArr[i]))
            input += chArr[i].ToString().ToLower();
            else
            input += chArr[i].ToString().ToUpper(); 
        }
        Console.WriteLine(input);
    }
}