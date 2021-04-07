using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class StringformatNumber
    {
        static void Main(string[] args)
        {
            WriteLine("10진수 : {0:D}", 123);
            WriteLine("10진수 : {0:D5}", 123);

            WriteLine("16진수 : 0x{0:X}", 0xFF1234);
            WriteLine("16진수 : 0x{0:X8}", 0xFF1234);

            WriteLine("숫자 : {0:N}", 123456789);
            WriteLine("숫자 : {0:N0}", 123456789);

            WriteLine("고정 소수점 : {0:F}", 123.45);
            WriteLine("고정 소수점 : {0:F5}", 123.456);

            WriteLine("공학용 : {0:E}", 123.456789);
        }
    }
}
