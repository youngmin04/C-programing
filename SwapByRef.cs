using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class SwapByRef
    {
        public static void Swap(ref int a,ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main()
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x : {x}, y : {y}");

            Swap(ref x,ref y);

            Console.WriteLine($"x : {x}, y : {y}");
        }
    }
}
