﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class UsingParams
    {
        static int Sum(params int[] args)
        {
            Console.WriteLine("Summing...");

            int sum = 0;

            for(int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine(", ");
                }
                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();
            return sum;
        }
        static void Main()
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine($"Sum :{sum}");
        }
    }
}
