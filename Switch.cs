﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class Switch
    {
        static void Main()
        {
            Write("요일을 입력하세요.(일, 월, 화, 수, 목, 금, 토) : ");
            string day = ReadLine();

            switch (day)
            {
                case "일":
                    WriteLine("Sunday");
                    break;
                case "월":
                    WriteLine("Monday");
                    break;
                case "화":
                    WriteLine("Tuseday");
                    break;
                case "수":
                    WriteLine("Wednesday");
                    break;
                case "목":
                    WriteLine("Thursday");
                    break;
                case "금":
                    WriteLine("Firday");
                    break;
                case "토":
                    WriteLine("Saturday");
                    break;
                default:
                    WriteLine($"{day}는(은) 요일이 아닙니다.");
                    break;
            }
        }
    }
}
