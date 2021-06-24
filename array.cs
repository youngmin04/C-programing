using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class array
    {
        static void Main()
        {
            int[] scores = new int[5];

            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;

            for(int i = 0; i < 5; i++)
            {
                WriteLine(scores[i]);
            }
            foreach(int score in scores)
            {
                WriteLine(score);
            }
            int[] scores2 = new int[]{10, 20, 30, 40, 50 };
            int[] scores3 = { 10, 20, 30, 40, 50 };
        }
    }
}
