using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class Test05
    {
        static void Main()
        {
            int[,] a = { { 3, 2 }, { 1, 4 } };
            int[,] b = { { 9, 2 }, { 1, 7 } };
            int[,] mul={ { a[0, 1] * b[0, 1] + a[0, 2] * b[1, 0] , a[0, 1] * b[0, 2] + a[0, 2] * b[1, 1] }, { a[1, 0] * b[0, 1] + a[1, 1] * b[1, 0], a[1, 0] * b[0, 2] + a[1, 1] * b[1, 1] } };

            for(int i = 0; i < 2; i++)
            {
                for(int j =0; j < 2; j++)
                {
                    WriteLine(mul[i,j]);
                }
            }
        }
    }
}
