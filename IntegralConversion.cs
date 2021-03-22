using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class IntegralConversion
    {
        static void Main(string[] arg)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128;
            Console.WriteLine(x);

            sbyte y = (sbyte)x;
            Console.WriteLine(y);
        }
    }
}
