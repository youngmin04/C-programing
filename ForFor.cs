using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class ForFor
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
