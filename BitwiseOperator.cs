﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class BitwiseOperator
    {
        static void Main()
        {
            int a = 9;
            int b = 10;

            WriteLine($"{a}&{b} : {a & b}");
            WriteLine($"{a}|{b} : {a | b}");
            WriteLine($"{a}^{b} : {a ^ b}");

            int c = 255;
            WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, -c);
        }
    }
}
