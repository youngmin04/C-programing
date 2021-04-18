using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class IfIf
    {
        static void Main()
        {
            Write("숫자를 입력하시오. : ");

            int input = int.Parse(ReadLine());

            if (input > 0)
            {
                if (input % 2 == 0)
                {
                    WriteLine("0보다 큰 짝수");
                }
                else
                {
                    WriteLine("0보다 큰 홀수");
                }
            }
            else
            {
                WriteLine("0보다 작거나 같은 수");
            }
        }
    }
}
