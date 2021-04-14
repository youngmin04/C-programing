using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Test01
    {
        static void Main()
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            int w = int.Parse(width);
            int h = int.Parse(height);

            Console.WriteLine("사각형의 넓이는 : " + w * h);
        }
    }
}
