using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class While
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine($"i : {i--}");
            }
        }
    }
}
