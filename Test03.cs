﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Test03
    {
        static double Square(double arg)
        {
            return arg * arg;
        }
        static void Main()
        {
            Console.WriteLine("수를 입력하세요");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과:{0}", Square(arg));
        }
    }
}
