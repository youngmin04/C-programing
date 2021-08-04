using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Global
    {
        public static int count = 0;
    }
    class ClassA
    {
        public ClassA()
        {
            Global.count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.count++;
        }
    }
    class StaticField
    {
        static void Main()
        {
            Console.WriteLine($"Global.Count : {Global.count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.count}");
        }
    }
}
