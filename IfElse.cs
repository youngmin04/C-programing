using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class IfElse
    {
        static void Main()
        {
            Write("숫자를 입력하세요. : ");

            string input = ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
            {
                WriteLine("음수");
            }
            else if(number>0)
            {
                WriteLine("양수");
            }
            else
            {
                WriteLine("0");
            }

            if (number % 2 == 0)
            {
                WriteLine("짝수");
            }
            else
            {
                WriteLine("홀수");
            }
        }
    }
}
