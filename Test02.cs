using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Test02
    {
        static void Main()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int min = arr[0];
            int max = arr[0];
            get_max_min(arr, ref min, ref max);
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
        private static void get_max_min(int[] arr,ref int min,ref int max)
        {
            for(int i = 0; i < 5; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
        }
    }
}
