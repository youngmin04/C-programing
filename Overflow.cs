using System;
using System.Collections.Generic;
using System.Text;
using static.System.Console;

namespace Programing
{
    class Overflow
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;

            WriteLine(a);

            a = a + 1;

            WriteLine(a);
        }
    }
}
