using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class ForEach
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
