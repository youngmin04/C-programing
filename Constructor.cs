using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Constructor
    {
        class cat
        {

            public cat()
            {
                Name = "";
                Color = "";
            }
            public cat(string _Name, string _Color)
            {
                Name = _Name;
                Color = _Color;
            }
            public string Name;
            public string Color;

            public void Meow()
            {
                Console.WriteLine($"{Name} : 야옹");
            }
            static void Main()
            {
                cat kitty = new cat("키티", "하얀색");
                kitty.Meow();
                Console.WriteLine($"{kitty.Name} : {kitty.Color}");

                cat nero = new cat("키티", "하얀색");
                nero.Meow();
                Console.WriteLine($"{nero.Name} : {nero.Color}");
            }
        }
    }
}
