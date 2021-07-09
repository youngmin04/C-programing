using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Product
    {
        private int price = 100;

        public ref int Getprice()
        {
            return ref price;
        }
        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }
    class RefReturn
    {
        static void Main()
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.Getprice();
            int normal_local_price = carrot.Getprice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Nomal Local Price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Nomal Local Price : {normal_local_price}");
        }
        

    }
}
