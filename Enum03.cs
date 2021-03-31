using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Enum03
    {
        enum DialogResult { Yes=10,No,Cancel,Confirm=50,Ok};

        static void Main()
        {
            Console.WriteLine((int)DialogResult.Yes);
            Console.WriteLine((int)DialogResult.No);
            Console.WriteLine((int)DialogResult.Cancel);
            Console.WriteLine((int)DialogResult.Confirm);
            Console.WriteLine((int)DialogResult.Ok);
        }
    }
}
