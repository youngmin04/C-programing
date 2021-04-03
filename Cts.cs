using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Cts
    {
        static void Main()
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type : {0}, value : {1}", a.GetType(), a);
            Console.WriteLine("b type : {0}, value : {1}", b.GetType(), b);

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type : {0}, value : {1}", c.GetType(), c);
            Console.WriteLine("d type : {0}, value : {1}", d.GetType(), d);
        }
    }
}
