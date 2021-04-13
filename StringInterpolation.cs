using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class StringInterpolation
    {
        static void Main()
        {
            string name = "김튼튼";
            int age = 23;
            WriteLine($"{name,-10},{age:D3}");

            name = "박날씬";
            age = 30;
            WriteLine($"{name},{age,-10:D3}");

            name = "이비실";
            age = 17;
            WriteLine($"{name},{(age>20?"성인":"미성년자")}");
        }
    }
}
