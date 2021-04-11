using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Ex6_2
    {
        public static void Main()
        {
            double mean = 0;

            Mean(1,2, 3, 4, 5, ref mean);

            Console.WriteLine("평균 : {0}", mean);
        }

        public static void Mean(double a,double b,double c,
            double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }

    }
}
