using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class IntegerLiterals
    {
        static void Main()
        {
            byte a = 240;
            Console.WriteLine($"a={0}",a);

            byte b = 0b11110000;
            Console.WriteLine($"b={0}", b);

            byte c = 0XF0;
            Console.WriteLine($"c={0}", c);

            uint d = 0x1234abcd;
            Console.WriteLine($"d={0}", d);
        }
    }
}
