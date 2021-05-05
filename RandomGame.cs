using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Game
    {
        static void Main()
        {
            while (true)
            {
                Random random = new Random();
                int a = random.Next(1, 4);

                Console.WriteLine("(1)가위 (2)바위 (3)보");
                int input1 = int.Parse(Console.ReadLine());

                if (input1 == 1 || input1 == 2 || input1 == 3)
                {
                    if (a == input1)
                    {
                        Console.WriteLine("비겼습니다.");
                    }
                    else if (a == 1 && input1 == 3 || a == 2 && input1 == 1 || a == 3 && input1 == 2)
                    {
                        Console.WriteLine("졌습니다.");
                    }
                    else
                    {
                        Console.WriteLine("이겼습니다.");
                    }
                }
                else
                {
                    Console.WriteLine("동작 그만 밑장빼기냐?!");
                }
            }
        }
    }
}
