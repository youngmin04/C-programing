using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Constant
    {
        static void Main()
        {
            const int a = int.MaxValue;
            const int b = int.MinValue;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //a = 3; // 변수값은 변경할 수 없다 그렇기에 오류 발생
        }
    }
}
