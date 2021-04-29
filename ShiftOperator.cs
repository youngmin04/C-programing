using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class ShiftOperator
    {
        static void Main()
        {
            WriteLine("Testing <<...");

            int a = 1;
            WriteLine("a : {0:D5}(0x{0:X8})", a);
            WriteLine("a << 1 : {0:D5}(0x{0:X8})", a<<1);
            WriteLine("a <<2 : {0:D5}(0x{0:X8})", a<<2);
            WriteLine("a <<5 : {0:D5}(0x{0:X8})", a<<5);

            WriteLine("\nTesting >>...");

            int b = 255;
            WriteLine("b : {0:D5}(0x{0:X8})", a);
            WriteLine("b >> 1 : {0:D5}(0x{0:X8})", b >> 1);
            WriteLine("b >> 2 : {0:D5}(0x{0:X8})", b >> 2);
            WriteLine("b >> 5 : {0:D5}(0x{0:X8})", b >> 5);

            WriteLine("\nTesting >> 2...");

            int c = -255;
            WriteLine("c : {0:D5}(0x{0:X8})", a);
            WriteLine("c >> 1 : {0:D5}(0x{0:X8})", c >> 1);
            WriteLine("c >> 2 : {0:D5}(0x{0:X8})", c >> 2);
            WriteLine("c >> 5 : {0:D5}(0x{0:X8})", c >> 5);
        }
    }
}
