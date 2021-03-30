using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Enum02
    { 
        enum DialogResult { Yes,No,Cancel,Confirm,Ok};
        static void Main()
        {
            DialogResult result = DialogResult.Yes;

            Console.WriteLine(result == DialogResult.Yes);
            Console.WriteLine(result == DialogResult.No);
            Console.WriteLine(result == DialogResult.Cancel);
            Console.WriteLine(result == DialogResult.Confirm);
            Console.WriteLine(result == DialogResult.Ok);
        }
    }
}
