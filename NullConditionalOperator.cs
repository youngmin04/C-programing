using System;
using System.Collections;
using System.Text;
using static System.Console;

namespace Programing
{
    class NullConditionalOperator
    {
        static void Main()
        {
            ArrayList a = null;
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList();
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
        }
    }
}
