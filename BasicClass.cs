using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    class BasicClass
    {
        static void Main()
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();

            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "하얀색";
            nero.Name = "키티";
            nero.Meow();

            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }

}
