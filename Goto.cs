﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Goto
    {
        static void Main()
        {
            Console.WriteLine("종료 조건(숫자)을 입력하세요.");
            string input = Console.ReadLine();

            int input_number = int.Parse(input);
            int exit_number = 0;

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        if (exit_number++ == input_number)
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);
                    }
                }
            }
            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");
        EXIT_PROGRAM:
            Console.WriteLine("\nEXit program...");
        }
    }
}
