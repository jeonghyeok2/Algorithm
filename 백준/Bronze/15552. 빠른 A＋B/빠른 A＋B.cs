using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
    public class Program {
        public static void Main()
        {
        ////입력 : 첫줄에 테스트케이스의 개수 T개가 주어진다(최대 1,000,000)
        int maxT = int.Parse(Console.ReadLine());
        int[] a = new int[maxT];
        int[] b = new int[maxT];
        StringBuilder abNumbers = new StringBuilder();
 
        ////두번쨰 입력줄 : 다음 T줄에 각각 정수 A,B가 주어진다. (1<A,B<1000)
        for (int i = 0; i < maxT; i++)
        {
            string[] ab = Console.ReadLine().Split(' ');
            a[i] = int.Parse(ab[0]);
            b[i] = int.Parse(ab[1]);
            abNumbers.Append(a[i]+b[i]+"\n");
        }
 
        //출력 : 테스트 케이스마다 A+B를 한줄에 하나씩 순서대로 출력한다.
        Console.WriteLine(abNumbers.ToString());
        }
    }