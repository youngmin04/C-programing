using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Continue
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"{i} : 홀수");
            }
        }
    }
}
