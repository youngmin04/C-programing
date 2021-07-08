﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class SwapByValue
    {
        public static void Swap(int a, int b)
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

            Swap(x, y);

            Console.WriteLine($"x : {x}, y : {y}");
        }
    }
}
