using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Constact
    {
        enum DialogResult {Yes,No,Cancel,Confirm,Ok  }
        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.Yes);
            Console.WriteLine((int)DialogResult.No);
            Console.WriteLine((int)DialogResult.Cancel);
            Console.WriteLine((int)DialogResult.Confirm);
            Console.WriteLine((int)DialogResult.Ok);
        }
    }
}
