using System;
using System.Collections;
using System.Text;

namespace Backjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 97; i < 123; i++)
            {   //Contains를 활용하여 문자열안에 문자 값이 들어있으면 true 없으면 false로 반환
                //ASCII코드를 활용하여 97 = a 부터 123 = z 까지 Covert.ToChar로 변환해서 값이 들어있는지 확인하기
                if (input.Contains(Convert.ToChar(i)))  
                    Console.Write(input.IndexOf(Convert.ToChar(i)) + " ");//indexOf에 char를 넣어 위치번호 확인하기
                else 
                    Console.Write(-1 + " ");
            }
        }
    }
}