﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Test
    {
        static void Main()
        {
            int num = 5;
            for (int i = 0; i < num; i++)
            {
                for (int j = num - 1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
