using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Usingvar
    {
        static void Main()
        {
            var a = 3;//입력된 값의 형태에 따라 형식 지정
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

            var c = "Hello World";
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };
            Console.WriteLine("Type : {0}, Value : {1}", d.GetType());
            foreach (var e in d)
                Console.Write("{0}", e);
            Console.WriteLine();

            
        }
    }
}
