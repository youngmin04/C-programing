using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class NamedParameter
    {
        static void PrintProfile(string name,string phone)
        {
            Console.WriteLine($"Name : {name}, Phone : {phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(name: "박지성", phone: "010-987-9876");
            PrintProfile(name: "박세리", phone: "010-222-2222");
            PrintProfile(name: "박상현", phone: "010-567-5678");
        }
    }
}
