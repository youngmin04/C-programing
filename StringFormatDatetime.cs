using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using static System.Console;

namespace Programing
{
    class StringFormatDatetime
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

            WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (ddd)}", dt);

            CultureInfo ciko = new CultureInfo("ko-KR");

            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciko));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)", ciko));
            WriteLine(dt.ToString(ciko));

            CultureInfo ciEn = new CultureInfo("en-Us");

            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString(ciEn));
        }
    }
}
