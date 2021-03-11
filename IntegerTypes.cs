using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class IntegerTypes
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -10000000;
            int f = 300000000;

            Console.WriteLine($"e={e}, f={f}");

            long g = -500000000000;
            ulong h = 2000000000000000000;

            Console.WriteLine($"g={g}, h={h}");
        }
    }
}
