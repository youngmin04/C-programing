﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Ex6_3
    {
        public static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0}+{1}={2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            Console.WriteLine("{0}+{1}={2}", x, y, resultB);
        }

        public static void Plus(int a,int b,out int c)
        {
            c = a + b;
        }
        public static void Plus(double x,double y,out double c)
        {
            c = x + y;
        }
    }
}
