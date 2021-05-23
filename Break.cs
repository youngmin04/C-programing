using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Break
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("계속 할까요?");
                string answer = Console.ReadLine();

                if (answer == "아니요")
                {
                    break;
                }
            }
        }
    }
}
