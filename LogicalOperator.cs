using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class LogicalOperator
    {
        static void Main()
        {
            WriteLine("Testing&&...");
            WriteLine($"1>0&&4<5:{1 > 0 && 4 < 5}");
            WriteLine($"1>0&&4>5:{1 > 0 && 4 > 5}");
            WriteLine($"1==0&&4>5:{1 == 0 && 4 > 5}");
            WriteLine($"1==0&&4<5:{1 == 0 && 4 < 5}");

            WriteLine("\nTesting||...");
            WriteLine($"1>0||4<5:{1 > 0 || 4 < 5}");
            WriteLine($"1>0||4>5:{1 > 0 || 4 > 5}");
            WriteLine($"1==0||4>5:{1 == 0 || 4 > 5}");
            WriteLine($"1==0||4<5:{1 == 0 || 4 < 5}");

            WriteLine("\nTesting !...");
            WriteLine($"!True:{!true}");
            WriteLine($"!False:{!false}");
        }
    }
}
