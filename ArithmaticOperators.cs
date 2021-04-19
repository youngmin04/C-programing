using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class ArithmaticOperators
    {
        static void Main()
        {
            int a = 111 + 222;
            Console.WriteLine(a);

            int b = a - 100;
            Console.WriteLine(b);

            int c = b * 10;
            Console.WriteLine(c);

            double d = c / 6.3;
            Console.WriteLine(d);

            Console.WriteLine($"22/7={22 / 7}({22 % 7})");
        }
    }
}
