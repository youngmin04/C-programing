using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class Test04
    {
        public static void Main()
        {
            WriteLine("키를 입력해주세요 : ");
            double tall=double.Parse(ReadLine());
            WriteLine("몸무게를 입력해주세요 : ");
            double kg= double.Parse(ReadLine());
            BMI(tall,kg);
        }
        private static void BMI(double tall,double kg)
        {
            double bmi=kg/(tall*tall);
            if (bmi < 18.5)
            {
                WriteLine("마른체중");
            }
            else if (bmi >= 18.5 && bmi < 25.0)
            {
                WriteLine("표준");
            }
            else if (bmi >= 25.0 && bmi < 30.0)
            {
                WriteLine("비만");
            }
            else if (bmi >= 30.0)
            {
                Write("고도 비만");
            }
        }
    }
}
